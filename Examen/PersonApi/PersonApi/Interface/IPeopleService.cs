using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Interface
{
    interface IPeopleService
    {
        public List<Person> GetAll();
        public Person GetById(int id);
        public Person Add(Person person);
        public void Delete(int id);
        public void Update(Person person);
    }
}
