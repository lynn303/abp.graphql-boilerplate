using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using abp.graphql-boilerplate.Configuration;
using abp.graphql-boilerplate.Web;

namespace abp.graphql-boilerplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class graphql-boilerplateDbContextFactory : IDesignTimeDbContextFactory<graphql-boilerplateDbContext>
    {
        public graphql-boilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<graphql-boilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            graphql-boilerplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(graphql-boilerplateConsts.ConnectionStringName));

            return new graphql-boilerplateDbContext(builder.Options);
        }
    }
}
