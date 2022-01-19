using BLL.Interface;
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
        public IUnitOfWork UnitOfWork { get; set; }

        public PeopleService(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        public Person Add(Person person)
        {
            UnitOfWork.peopleRepository.Add(person);
            UnitOfWork.Commit();
            return person;
        }

        public void Delete(int id)
        {
            Person person = UnitOfWork.peopleRepository.GetById(id);
            if (person != null)
            {
                UnitOfWork.peopleRepository.Delete(id);
                UnitOfWork.Commit();
            } 
            else
            {
                throw new KeyNotFoundException($"id: {id}");
            }
        }

        public List<Person> GetAll()
        {
            return UnitOfWork.peopleRepository.GetAll();
        }

        public Person GetById(int id)
        {
            return UnitOfWork.peopleRepository.GetById(id);
        }

        public void Update(Person person)
        {
            UnitOfWork.peopleRepository.Update(person);
            UnitOfWork.Commit();

        }
    }
}
