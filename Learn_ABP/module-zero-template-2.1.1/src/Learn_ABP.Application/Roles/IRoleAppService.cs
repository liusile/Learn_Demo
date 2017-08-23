using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learn_ABP.Roles.Dto;

namespace Learn_ABP.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
