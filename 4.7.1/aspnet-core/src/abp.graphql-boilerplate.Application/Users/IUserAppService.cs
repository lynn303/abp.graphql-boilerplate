using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abp.graphql-boilerplate.Roles.Dto;
using abp.graphql-boilerplate.Users.Dto;

namespace abp.graphql-boilerplate.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
