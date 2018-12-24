using AutoMapper;
using LZN.Core.Data;
using LZN.Core.IRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.DomainService.DomainService.Login
{
  public  class LoginService:ILoginService
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
    }
}
