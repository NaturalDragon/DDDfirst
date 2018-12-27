using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using DotNetCore.CAP;
using LZN.Application.PersonApp;
using LZN.EntityFramwork;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LZN.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public IPersonService _personService;

        private readonly ICapPublisher _capBus;

        public ValuesController(IPersonService personService,ICapPublisher capPublisher)
        {

            _personService = personService;
            _capBus = capPublisher;
          
        }

        [HttpGet("TestCap")]
        public async Task<object> TestCap()
        {

            


            await _capBus.PublishAsync("xxx.services.show.time", DateTime.Now);
            return "o";
        }
        [CapSubscribe("xxx.services.show.time")]
        public void ShowTime(DateTime now)
        {
            Console.WriteLine($"时间时间时间时间时间时间时间：{now}");
        }
        [HttpGet("Test")]
        public async Task<object> Test()
        {
            await _personService.AddPerson(new LZN.Application.Dtos.Person.PersonRequestDto
            { Id = Guid.NewGuid().ToString(), Name = $"wo{DateTime.Now.ToString()}", CreateDate = DateTime.Now ,RoleId="2" });

            var result = await _personService.GetAll();
            return result.Count();
         //   return 
        
        }

        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
