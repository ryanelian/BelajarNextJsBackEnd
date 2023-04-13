using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar.Entities.DesignTime
{
    internal class DesignTimeApplicationDbContext : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=local.db");

            var db = new ApplicationDbContext(optionsBuilder.Options);
            return db;
        }

        //protected override void onconfiguring(dbcontextoptionsbuilder optionsbuilder)
        //{
        //    optionsbuilder.usesqlite("data source = ../belajar.entities/database/belajar.db");
        //    var db = new applicationdbcontext(optionsbuilder.options);
        //   return db;
        //}
    }
}
