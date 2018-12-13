using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.EntityFramwork
{
  public  class UnitOfWorkDbContext:DbContext, IUnitOfWorkDbContext
    {


        public DbSet<LZN.Core.Model.Person> People { get; set; }


       
        public UnitOfWorkDbContext(DbContextOptions<UnitOfWorkDbContext> dbContextOptions):base(dbContextOptions)
        {

            //dbContextOptions.
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=171.221.227.116,21871;uid=sa;pwd=Asd123$;database=Test;");
        }
    }
}
