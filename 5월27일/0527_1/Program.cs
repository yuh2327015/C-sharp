using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_1
{
    public class Parent
    {
        public void Say() => Console.WriteLine("부모_안녕하세요");
        public void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다");
    }
    public class Child : Parent
    {
        public new void Say() => Console.WriteLine("자식_안녕하세요");
        public new void Run() => Console.WriteLine("자식_달리다.");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Say();
            child.Run();

        }
    }
}
