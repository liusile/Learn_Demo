using System.Threading.Tasks;
using Abp.Application.Services;
using Learn_ABP.Sessions.Dto;

namespace Learn_ABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
