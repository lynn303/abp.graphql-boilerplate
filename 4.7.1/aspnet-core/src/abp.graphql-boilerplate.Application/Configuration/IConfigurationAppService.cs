using System.Threading.Tasks;
using abp.graphql-boilerplate.Configuration.Dto;

namespace abp.graphql-boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
