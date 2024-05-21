using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 자동차가 달립니다");
        }
    }
    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 자동차가 달립니다");
        }
    }
}


namespace _0513_6
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Korea.Seoul.Car s = new Korea.Seoul.Car();
            s.Run();
            Korea.Incheon.Car i = new Korea.Incheon.Car();
            i.Run();

            Korea.Incheon.Car seoul = new Korea.Incheon.Car();
            seoul.Run();

           
        }
    }
}
