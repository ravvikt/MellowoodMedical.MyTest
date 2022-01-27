using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MellowoodMedical.MyTest.Roles.Dto;
using MellowoodMedical.MyTest.Users.Dto;

namespace MellowoodMedical.MyTest.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
