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

        Task<int> AddPerson(Person person);
    }
}
