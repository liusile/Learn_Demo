using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Learn_ABP.Configuration.Dto;

namespace Learn_ABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Learn_ABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
