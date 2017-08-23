using System.Threading.Tasks;
using Abp.Application.Services;
using Learn_ABP.Authorization.Accounts.Dto;

namespace Learn_ABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
