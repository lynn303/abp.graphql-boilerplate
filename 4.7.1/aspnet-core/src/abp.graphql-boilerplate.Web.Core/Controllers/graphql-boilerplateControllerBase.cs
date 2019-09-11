using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abp.graphql-boilerplate.Controllers
{
    public abstract class graphql-boilerplateControllerBase: AbpController
    {
        protected graphql-boilerplateControllerBase()
        {
            LocalizationSourceName = graphql-boilerplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
