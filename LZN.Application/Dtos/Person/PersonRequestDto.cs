using LZN.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LZN.Application.Dtos.Person
{
    public class PersonRequestDto: BaseDto
    {
      


        public string RoleId { set; get; }


        public string Name { set; get; }



        public string PhoneCode { set; get; }


    }
}
