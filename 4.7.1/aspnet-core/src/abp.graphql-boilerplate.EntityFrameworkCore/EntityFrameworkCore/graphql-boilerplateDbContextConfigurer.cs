using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace abp.graphql-boilerplate.EntityFrameworkCore
{
    public static class graphql-boilerplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<graphql-boilerplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<graphql-boilerplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
