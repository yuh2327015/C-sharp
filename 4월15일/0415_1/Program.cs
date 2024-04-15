using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //제네릭 사용전
            Stack s1 = new Stack();
            s1.Push(1234);
            int i1 = (int)s1.Pop();
            Console.WriteLine(i1);
            //제네릭 사용후
            Stack<int> s2 = new Stack<int>();
            s2.Push(2345);
            int i2 = s2.Pop();
            Console.WriteLine(i2);
            //제네릭의 장점 : 형식 안정성과 성능 향상 // 타입 안전성
            Stack o = new Stack();
            o.Push(1234);
            o.Push("Hello");
            Console.WriteLine(o.Pop());
            Console.WriteLine(o.Pop());
            Stack<int> i = new Stack<int>();
            i.Push(1234);

            Console.WriteLine(i.Pop());

            Stack stack = new Stack();
            stack.Push(1234);
            int iStack = (int)stack.Pop();
            Console.WriteLine(iStack);
        }
    }
}
