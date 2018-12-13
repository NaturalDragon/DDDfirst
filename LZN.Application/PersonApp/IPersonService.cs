using LZN.Application.Dtos.Person;
using LZN.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LZN.Application.PersonApp
{
   public interface IPersonService
    {

        bool Login(Person person);

        Task<IEnumerable<PersonQueryDto>> GetAll();
        Task<int> AddPerson(PersonRequestDto person);
    }
}
