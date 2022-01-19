using Microsoft.AspNetCore.Mvc;
using PersonApi.Context;
using PersonApi.Interface;
using PersonApi.Model;
using PersonApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public IPeopleService PeopleService { get; set; }

        //public List<Person> people { get; set; }

        public PersonController(IPeopleService PeopleService)
        {
            this.PeopleService = PeopleService;

            //people = new List<Person>();
            //people.Add(new Person(0 , "Lucca", "Boets", 1, "Mail"));
            //people.Add(new Person(1 , "Issam", "El Khattabi", 1, "Mail"));
        }

        [HttpGet]
        public IActionResult GetPersons()
        {
            var result = PeopleService.GetAll();

            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetPersonById(int id)
        {
            return Ok(PeopleService.GetById(id));
        }

        [HttpDelete]
        public IActionResult DeletePerson(int id)
        {
            try
            {
                PeopleService.Delete(id);
                return Ok();

            }
            catch (KeyNotFoundException e)
            {
                return NoContent();
            }
        }

        [HttpPost]
        public IActionResult PostPerson([FromBody] Person person)
        {
            PeopleService.Add(person);
            return new CreatedResult("add", person);
        }

        [HttpPut]
        public IActionResult PutPerson([FromBody] Person person)
        {
            PeopleService.Update(person);
            return Ok();
        }
    }
}
