using BLL.Interface;
using PersonApi.Context;
using PersonApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPeopleRepository peopleRepository { get; }
        public PersonContext personContext { get; }

        public UnitOfWork(IPeopleRepository peopleService, PersonContext personContext)
        {
            this.peopleRepository = peopleService;
            this.personContext = personContext;
        }

        public int Commit()
        {
            return personContext.SaveChanges();
        }
    }
}
