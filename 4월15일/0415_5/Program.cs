using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(11, 10);

            var sortedEvenNumbers = 
                numbers.Where(n=> n%2 == 0).OrderByDescending(n=>n);

            foreach (var item in sortedEvenNumbers)
            {
                Console.WriteLine(item);
            }

            int[] arr = { 1, 2, 3, 4, 5 };

            var evenNumbers =
                from num in arr
                where num %2 == 0
                select num;
            foreach (var number in evenNumbers)
            {
                Console.WriteLine($"짝수 : {number}");
            }

            
        }
    }
}
