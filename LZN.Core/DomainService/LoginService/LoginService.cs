using AutoMapper;
using LZN.Core.Data;
using LZN.Core.IRespository;
using LZN.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LZN.Core.DomainService.LoginService
{
  public  class LoginService: ILoginService
    {
        public IPersonRespository _personRespository;
        public IRoleRespository _roleRespository;
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LoginService(IPersonRespository personRespository,IRoleRespository roleRespository, IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _personRespository = personRespository;
            _roleRespository = roleRespository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Register(Person person)
        {
            var role = await _roleRespository.Entities.Where(r => r.Id == person.RoleId).SingleOrDefaultAsync();
            if (role == null)
            {
                return false;
            }
              await  _personRespository.Add(person);
            return true;
         //   _roleRespository.Add(role);
        }
    }
}
