using E_CommerceSystemV2.BL.DTOs.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_CommerceSystemV2.BL.Managers.Identity
{
    public interface IUserManager
    {
        public Task<IEnumerable<IdentityError>> Register(RegisterDto userFromRequest);
        public Task<LogInResultDto> LogIn(LogInDto credentials);
        public Task<UserReadDto>GetUserDetailsById(string id);
    }
}
