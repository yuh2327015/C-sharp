using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0513_5
{
    class My { }
    class Your
    {
        public override string ToString()
        {
            return "새로운 반환 문자열 지정";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            My my = new My();
            Console.WriteLine(my);
            Your your = new Your();
            Console.WriteLine(your);
        }
    }
}
