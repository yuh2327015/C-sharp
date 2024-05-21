using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0513_9
{
    internal class SalaryEmployee : Employee
    {
        public decimal Salary { get; }
        public SalaryEmployee(int id, decimal salary) 
            :base(id)
        {
            Salary = salary;
        }

        public override decimal CalulatePay()
        {
            return Salary;
        }
    }
}
