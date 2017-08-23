using System.Threading.Tasks;
using Abp.Application.Services;
using Learn_ABP.Configuration.Dto;

namespace Learn_ABP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}