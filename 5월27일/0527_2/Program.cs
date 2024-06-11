using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0527_2
{
    class Parent
    {
        public virtual void Work() => Console.WriteLine("프로그래머");
    }
    class Child : Parent
    {
        public override sealed void Work() => base.Work();
    }
    class GrandChild : Child
    {
        //public override void Work() => Console.WriteLine("프로게이머");
        public void Play() => Console.WriteLine("프로게이머");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Parent()).Work();
            (new Child()).Work();
            (new GrandChild()).Work();
            (new GrandChild()).Play();
        }
    }
}
