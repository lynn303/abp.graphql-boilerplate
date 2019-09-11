using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using abp.graphql-boilerplate.Authorization.Roles;
using abp.graphql-boilerplate.Authorization.Users;
using abp.graphql-boilerplate.MultiTenancy;

namespace abp.graphql-boilerplate.EntityFrameworkCore
{
    public class graphql-boilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, graphql-boilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public graphql-boilerplateDbContext(DbContextOptions<graphql-boilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
