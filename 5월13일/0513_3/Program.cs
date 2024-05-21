using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0513_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hong = new { Name = "홍길동", Age = 21 };
            var park = new { Name ="박문수",  Age = 30 };

            Console.WriteLine($"이름 : {hong.Name},나이 : {hong.Age}");
            Console.WriteLine($"이름 : {park.Name},나이 : {park.Age}");
        }
    }
}
