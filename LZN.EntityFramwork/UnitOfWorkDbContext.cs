
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.EntityFramwork
{
  public  class UnitOfWorkDbContext:DbContext, IUnitOfWorkDbContext
    {


        public DbSet<LZN.Core.Model.Person> people { get; set; }


       
        public UnitOfWorkDbContext(DbContextOptions<UnitOfWorkDbContext> dbContextOptions):base(dbContextOptions)
        {

            //dbContextOptions.
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=112.74.59.197;uid=root;pwd=LZN520cy&xnn;database=Test;");
        }
    }
}
