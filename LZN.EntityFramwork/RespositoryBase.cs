using LZN.Core;
using LZN.Core.Data;
using LZN.EntityFramwork.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZN.EntityFramwork
{
    public abstract class RespositoryBase<TEntity>
       : RespositoryBase<TEntity,Guid>, IRespositoryBase<TEntity,Guid>
       where TEntity : class,IEntity<Guid>
    {
      
        public RespositoryBase(UnitOfWorkDbContext dbDbContext) : base(dbDbContext)
        {
        }
    }


    public abstract class RespositoryBase<TEntity, TPrimaryKey> :
         IRespositoryBase<TEntity, TPrimaryKey>, IRespositoryWithDbContext
          where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly DbSet<TEntity> _dbSet;

        private readonly UnitOfWorkDbContext _dbContext;

        public DbContext GetDbContext()
        {
            return _dbContext;
        }



        public RespositoryBase(UnitOfWorkDbContext dbContext)
        {

            _dbContext = (UnitOfWorkDbContext)dbContext;
            _dbSet = _dbContext.Set<TEntity>();

        }
        public IQueryable<TEntity> Entities
        {
            get
            {

                return _dbSet.AsQueryable();
            }
        }
        public async Task Add(TEntity entity, bool isSave = true)
        {
            await _dbSet.AddAsync(entity);
        }


    }
}
