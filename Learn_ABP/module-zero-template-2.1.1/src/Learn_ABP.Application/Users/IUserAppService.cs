using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learn_ABP.Roles.Dto;
using Learn_ABP.Users.Dto;

namespace Learn_ABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}