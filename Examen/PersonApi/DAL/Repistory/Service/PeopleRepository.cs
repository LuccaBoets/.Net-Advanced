using PersonApi.Context;
using PersonApi.Interface;
using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Service
{
    public class PeopleRepository : IPeopleRepository
    {
        public PersonContext PersonContext { get; set; }

        public PeopleRepository(PersonContext personContext)
        {
            PersonContext = personContext;
        }

        public Person Add(Person person)
        {
            PersonContext.People.Add(person);
            return person;
        }

        public void Delete(int id)
        {
            Person person = PersonContext.People.Find(id);
            if (person != null)
            {
                PersonContext.People.Remove(person);
            } 
            else
            {
                throw new KeyNotFoundException($"id: {id}");
            }
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
            PersonContext.Update(person);

        }
    }
}
