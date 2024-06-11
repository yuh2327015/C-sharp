using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_7
{
    class Vender : IPayable
    {
        public int Id { get; }
        public decimal TotalInvoices { get; }

        public Vender( int id, decimal totalInvoices ) 
        { 
            Id = id;
            TotalInvoices = totalInvoices;
        }

        public decimal CalulatePay()
        {
            return TotalInvoices;
        }
    }
}
