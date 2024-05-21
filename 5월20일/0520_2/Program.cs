using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0520_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(@"C:\Temp\Test.txt");

            Console.WriteLine("{0}",sr.ReadToEnd());

            sr.Close();
            sr.Dispose();
        }
    }
}
