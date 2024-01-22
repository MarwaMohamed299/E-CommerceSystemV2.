﻿using E_CommerceSystemV2.BL.DTOs.Identity;
using E_CommerceSystemV2.BL.Managers.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceSystemV2.API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterDto userDto)
        {
            var result = await _userManager.Register(userDto);
            if (result is null)
            {
                return Ok("User Created Successfully");
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost]
        [Route("Account/Login")]
        public async Task<ActionResult<LogInResultDto>> Login(LogInDto credentials)
        {
            var result = await _userManager.LogIn(credentials);
            return result;
        }

        [HttpGet]
        [Route("Account/UserDetails")]
        [Authorize]
        public async Task <ActionResult<UserReadDto>>GetUserDetailsById(string id)
        {
            var result = await _userManager.GetUserDetailsById(id);
            return result;
        }
    }
}
