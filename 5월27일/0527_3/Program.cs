using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_3
{
    interface IBattery
    {
        string GetName();
    }
    class Good : IBattery
    {
        public string GetName() => "Good";
    }
    class Bad : IBattery
    {
        public string GetName() => "Bad";
    }
    class Car
    {
        private IBattery _battery;
        public Car(IBattery battery)
        {
            _battery = battery;
        }
        public void Run() => Console.WriteLine(
            "{0} 배터리를 장착한 자동차가 달립니다.", _battery.GetName());
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var good = new Car(new Good()); good.Run();
            new Car(new Bad()).Run();
        }
    }
}
