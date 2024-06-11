using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_7
{
    interface IPayable
    {
        int Id { get; }
        decimal CalculatePay();
    }
}
