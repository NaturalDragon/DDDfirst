using System;
using System.Collections.Generic;
using System.Text;
using LZN.Core.Model;
using System.Linq;
using LZN.Core.IRespository;
using System.Threading.Tasks;
using LZN.Core.Data;

namespace LZN.Application.PersonApp
{
    public class PersonService : IPersonService
    {
        public IPersonRespository _personRespository;
        public IUnitOfWork _unitOfWork;

        public PersonService(IPersonRespository personRespository, IUnitOfWork unitOfWork)
        {
            _personRespository = personRespository;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> AddPerson(Person person)
        {
            await _personRespository.Add(person);
          return  await _unitOfWork.SaveChangesAsync();
        }

        public bool Login(Person person)
        {
          return _personRespository.Entities.Where(p => p.Name != "").ToList().Count>0;
        }
    }
}
