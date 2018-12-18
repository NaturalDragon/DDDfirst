﻿using System;
using System.Collections.Generic;
using System.Text;
using LZN.Core.Model;
using System.Linq;
using LZN.Core.IRespository;
using System.Threading.Tasks;
using LZN.Core.Data;
using LZN.Application.Dtos.Person;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using LZN.Data.Ext;
namespace LZN.Application.PersonApp
{
    public class PersonService : IPersonService
    {
        public IPersonRespository _personRespository;
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PersonService(IPersonRespository personRespository, IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _personRespository = personRespository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> AddPerson(Dtos.Person.PersonRequestDto personRequest)
        {
            

            var person = _mapper.Map<PersonRequestDto, Person>(personRequest);
            await _personRespository.Add(person);
          return  await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<PersonQueryDto>> GetAll()
        {
            //var list= await _personRespository.Entities.Where(p => p.Name != "").ToListAsync();

            //return list.MapToList<Person, PersonQueryDto>();
            return null;
        }
      
        public bool Login(Person person)
        {
          return _personRespository.Entities.Where(p => p.Name != "").ToList().Count>0;
        }
    }
}
