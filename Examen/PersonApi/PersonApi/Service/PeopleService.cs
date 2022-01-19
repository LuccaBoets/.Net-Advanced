using PersonApi.Context;
using PersonApi.Interface;
using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Service
{
    public class PeopleService : IPeopleService
    {
        public PersonContext PersonContext { get; set; }

        public PeopleService(PersonContext personContext)
        {
            PersonContext = personContext;
        }

        public Person Add(Person person)
        {
            PersonContext.People.Add(person);
            PersonContext.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            Person person = new() { id = id };
            PersonContext.People.Remove(person);
            PersonContext.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return PersonContext.People.ToList();
        }

        public Person GetById(int id)
        {
            return PersonContext.People.FirstOrDefault(x => x.id == id);
        }

        public void Update(Person person)
        {
                        PersonContext.SaveChanges();


        }
    }
}
