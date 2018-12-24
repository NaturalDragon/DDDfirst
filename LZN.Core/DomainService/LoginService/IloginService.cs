using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LZN.Core.DomainService.LoginService
{
   public interface ILoginService
    {
        Task<bool> Register(Model.Person person);
    }
}
