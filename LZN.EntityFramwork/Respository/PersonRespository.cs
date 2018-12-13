using LZN.Core.Data;
using LZN.EntityFramwork.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.EntityFramwork.Respository
{
    public class PersonRespository : RespositoryBase<LZN.Core.Model.Person>, LZN.Core.IRespository.IPersonRespository
    {
        public PersonRespository(UnitOfWorkDbContext dbDbContext) : base(dbDbContext)
        {
        }
    }
}
