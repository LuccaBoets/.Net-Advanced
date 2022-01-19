using PersonApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IUnitOfWork
    {

        public int Commit();

        public IPeopleRepository peopleRepository { get; }

    }
}
