﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 5);
            foreach (var n in numbers)
                Console.Write("{0}\t", n);
            Console.WriteLine();

            var sameNumbers = Enumerable.Range(-1, 5);
            foreach (var n in sameNumbers)
                Console.Write("{0}\t", n);
            Console.WriteLine();
        }
    }
}
