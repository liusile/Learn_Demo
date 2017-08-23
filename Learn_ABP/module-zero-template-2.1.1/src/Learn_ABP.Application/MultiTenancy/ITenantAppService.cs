using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learn_ABP.MultiTenancy.Dto;

namespace Learn_ABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
