using E_CommerceSystemV2.BL.DTOs.Identity;
using E_CommerceSystemV2.BL.Managers.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_CommerceSystemV2.API.Controllers.Users;

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
    [Route("Login")]
    public async Task<ActionResult<LogInResultDto>> Login(LogInDto credentials)
    {
        var result = await _userManager.LogIn(credentials);
        return result;
    }

    [HttpGet]
    [Route("UserDetails")]
    [Authorize]
    public async Task <ActionResult<UserReadDto>>GetUserDetailsById(string id)
    {
        var result = await _userManager.GetUserDetailsById(id);
        return result;
    }

    [HttpGet]
    [Route("UserDetails2")]
    [Authorize]
    public async Task<ActionResult<UserReadDto>> GetUserDetailsByToken()
    {
        var id = User.FindFirstValue(ClaimTypes.NameIdentifier);  
        //var email = User.Claims.First(c => c.Type == ClaimTypes.Email);
        //var name = User.FindFirstValue(ClaimTypes.Name);
        var user = await _userManager.GetUserDetailsById(id!);
        return user!; 
    }
}
