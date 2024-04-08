using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0408_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < 10000; i++ ) { sb.Append("안녕하세요."); }
            DateTime end = DateTime.Now;
            double exec = (end - start).TotalMilliseconds;
            Console.WriteLine(exec);    
        }
    }
}
