using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0401_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unique = Guid.NewGuid().ToString();
            Console.WriteLine($"유일한 값 : {unique}");
            Console.WriteLine($"유일한 값 : {Guid.NewGuid().ToString("D")}");
        }
    }
}
