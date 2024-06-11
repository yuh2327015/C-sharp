using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_5
{
    public interface IStandard { void Run(); }  

    public abstract class KS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }
    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }
    public sealed class Car : MyCar, IStandard
    {
        public void Run() => Console.WriteLine("전진");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car cla = new Car();
            cla.Run(); cla.Left(); cla.Right(); cla.Back();
        }
    }
}
