using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_6
{
    abstract class Employee
    {
        public int Id { get;}

        public Employee(int id)
        {
            Id = id;
        }

        public abstract decimal CalculatePay();
    }
}
