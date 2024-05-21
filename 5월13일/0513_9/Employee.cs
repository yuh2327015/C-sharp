﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0513_9
{
    internal class Employee
    {
        public int Id { get; }

        public Employee(int id)
        {
            Id = id;
        }

       
        public virtual decimal CalulatePay()
        {
            return 0m;
        }
    }
}
