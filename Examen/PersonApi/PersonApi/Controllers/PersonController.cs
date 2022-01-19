﻿using Microsoft.AspNetCore.Mvc;
using PersonApi.Context;
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
        public PeopleService PeopleService { get; set; }

        //public List<Person> people { get; set; }

        public PersonController(PeopleService PeopleService)
        {
            this.PeopleService = PeopleService;

            //people = new List<Person>();
            //people.Add(new Person(0 , "Lucca", "Boets", 1, "Mail"));
            //people.Add(new Person(1 , "Issam", "El Khattabi", 1, "Mail"));
        }

        [HttpGet]
        public IActionResult GetPersons()
        {
            return Ok(PeopleService.GetAll());
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
            PeopleService.Delete(id);
            return NoContent();
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