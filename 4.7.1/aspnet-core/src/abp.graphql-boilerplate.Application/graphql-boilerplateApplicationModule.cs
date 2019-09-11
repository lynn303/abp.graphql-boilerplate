using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp.graphql-boilerplate.Authorization;

namespace abp.graphql-boilerplate
{
    [DependsOn(
        typeof(graphql-boilerplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class graphql-boilerplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<graphql-boilerplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(graphql-boilerplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
