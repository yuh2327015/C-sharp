using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0513_9
{
    internal class HourlEmployee : Employee
    {
        public decimal Wage { get; }
        public double Hours { get; }

        public HourlEmployee(int id, decimal wage, double hours)
             : base(id)
        {
            Wage = wage;
            Hours = hours;
        }

        public override decimal CalulatePay()
        {
            return Wage * (decimal)Hours;
        }
    }
}
