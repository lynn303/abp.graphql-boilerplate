using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using abp.graphql-boilerplate.Configuration.Dto;

namespace abp.graphql-boilerplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : graphql-boilerplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
