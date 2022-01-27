using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MellowoodMedical.MyTest.Configuration.Dto;

namespace MellowoodMedical.MyTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
