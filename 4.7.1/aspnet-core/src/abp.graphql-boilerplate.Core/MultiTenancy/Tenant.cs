using Abp.MultiTenancy;
using abp.graphql-boilerplate.Authorization.Users;

namespace abp.graphql-boilerplate.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
