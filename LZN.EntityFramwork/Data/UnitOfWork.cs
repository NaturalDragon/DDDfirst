using LZN.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LZN.EntityFramwork.Data
{
    public class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext:UnitOfWorkDbContext
    {
        private readonly TDbContext _dbContext;

        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext??throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<int> SaveChangesAsync()
        {
            return  await _dbContext.SaveChangesAsync();
        }

       
    }
}
