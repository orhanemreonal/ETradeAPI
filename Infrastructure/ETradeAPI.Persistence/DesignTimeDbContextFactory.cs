using ETradeAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETradeAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETradeAPIDbContext>
    {
        public ETradeAPIDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<ETradeAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);

            return new ETradeAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
