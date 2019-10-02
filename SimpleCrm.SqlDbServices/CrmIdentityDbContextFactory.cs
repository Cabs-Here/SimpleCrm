using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace SimpleCrm.SqlDbServices
{
    public class CrmIdentityDbContextFactory : IDesignTimeDbContextFactory<CrmIdentityDbContext>
    {
        public CrmIdentityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CrmIdentityDbContext>();
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SimpleCrm;Trusted_Connection=True;MultipleActiveResultSets=true",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(CrmIdentityDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new CrmIdentityDbContext(builder.Options);
        }
    }
}
