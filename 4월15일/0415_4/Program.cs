using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            IEnumerable<int> newNumbers = numbers.Where(number => number > 3);
            foreach (var n in newNumbers) 
            { 
                Console.WriteLine(n);
            }
            List<int> newNumberss = numbers.Where(number => number>3).ToList();
            foreach (var n in newNumberss)
            {
                Console.WriteLine(numbers);
            }
            var data = Enumerable.Range(0, 100);

            var next = data.Skip(10).Take(5);

            foreach (var n in next)
            {
                Console.Write(n);
            }

            
        }
    }
}
