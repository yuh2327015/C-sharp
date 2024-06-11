using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0603_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); }); 
        }
    }
}
