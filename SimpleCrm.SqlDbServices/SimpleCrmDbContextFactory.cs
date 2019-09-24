using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace SimpleCrm.SqlDbServices
{
    public class SimpleCrmDbContextFactory : IDesignTimeDbContextFactory<SimpleCrmDbContext>
    {
        public SimpleCrmDbContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
