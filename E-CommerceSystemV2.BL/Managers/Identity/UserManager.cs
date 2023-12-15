using E_CommerceSystemV2.BL.DTOs.Identity;
using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_CommerceSystemV2.BL.Managers.Identity
{
    public class UserManager : IUserManager
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;

        public UserManager(UserManager<User> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }


        public async Task<IEnumerable<IdentityError>> Register(RegisterDto userFromRequest)
        {
            User user = new User
            {
               UserName=userFromRequest.UserName,
                Email = userFromRequest.Email,
                CreationDate = userFromRequest.CreationDate

            };
            var RegisterResult = await _userManager.CreateAsync(user, userFromRequest.Password);
            if (!RegisterResult.Succeeded)
            {
                return RegisterResult.Errors;
            }
            else
            {
                var userClaims = new List<Claim>
                {
                    new Claim (ClaimTypes.NameIdentifier,userFromRequest.UserName),
                    new Claim(ClaimTypes.Email, userFromRequest.Email),
                    new Claim("Nationality", "Egyptian"),
                };
                await _userManager.AddClaimsAsync(user, userClaims);
                return null;
            }
        }
        public async Task<LogInResultDto> LogIn(LogInDto credentials)
        {
            LogInResultDto resultDto = new LogInResultDto();

            var User = await _userManager.FindByNameAsync(credentials.UserName);
            if (User == null)
            {
                resultDto.IsSuccess = false;
                resultDto.Message = "User Name Or Password Isn't Correct";
                return resultDto;
            }
            if (await _userManager.IsLockedOutAsync(User))
            {
                resultDto.IsSuccess = false;
                resultDto.Message = "User Is Locked, Try again after 10 minutes";
                return resultDto;
            }
            if (!(await _userManager.CheckPasswordAsync(User, credentials.Password)))
            {
                await _userManager.AccessFailedAsync(User);
                resultDto.IsSuccess = false;
                resultDto.Message = "User Name Or Password Isn't Correct";
                return resultDto;
            }

            //Key Generation

            var SecretKey = _config["SecretKey"];
            var secretKeyInBytes = Encoding.ASCII.GetBytes(SecretKey);      

           var Key = new SymmetricSecurityKey(secretKeyInBytes);
            //Hashing 
            var generatingToken = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256Signature);
            var userClaims = await _userManager.GetClaimsAsync(User);

            //Generate token
            var jwt = new JwtSecurityToken
                (
                    claims: userClaims,
                    notBefore: DateTime.Now,
                    issuer: "BackendTeam",
                    audience: "users",
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: generatingToken
                );
            var tokenHandler = new JwtSecurityTokenHandler();
            string tokenString = tokenHandler.WriteToken(jwt);
            resultDto.IsSuccess = true;
            resultDto.Message = "Login Successfully";
            resultDto.Token = tokenString;
            resultDto.ExpiryDate = jwt.ValidTo;
            return resultDto;


        }


    }





}
