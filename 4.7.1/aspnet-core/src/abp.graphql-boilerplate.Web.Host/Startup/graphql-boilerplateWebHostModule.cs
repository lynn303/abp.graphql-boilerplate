using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp.graphql-boilerplate.Configuration;

namespace abp.graphql-boilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(graphql-boilerplateWebCoreModule))]
    public class graphql-boilerplateWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public graphql-boilerplateWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(graphql-boilerplateWebHostModule).GetAssembly());
        }
    }
}
