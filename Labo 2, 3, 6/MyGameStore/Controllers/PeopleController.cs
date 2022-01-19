using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyGameStore.Contexts;
using MyGameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Controllers
{
    [Route("api/v1/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public MyGameStoreContext people { get; set; }
        public PeopleController(MyGameStoreContext people)
        {
            this.people = people;
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(people.People);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentWithId(int id)
        {
            return Ok(people.People.First(x => x.id == id));
        }

        [HttpGet("lastName/{lastName}")]
        public IActionResult GetStudentWithLastName(string lastName)
        {
            return Ok(people.People.First(x => x.LastName == lastName));
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody]Person person)
        {
            people.People.Add(person);
            people.SaveChanges();
            return new CreatedResult("add", person);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var temp = people.People.Where(x => x.id == id).First();
            people.People.Remove(temp);
            people.SaveChanges();

            return NoContent();
        }

        //[Route("Name")]
        //[HttpPost]
        //public IActionResult ChangeStudentFirstName(int id, string firstName)
        //{
        //    people.Remove(people.Where(x => x.id == id).First());

        //    return Ok(people);
        //}
    }
}
