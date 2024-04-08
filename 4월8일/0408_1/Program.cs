using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace _0408_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProess();
            timer.Stop();

            Console.WriteLine("경과 시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
            Console.WriteLine("경과 시간 : {0}초", timer.Elapsed.Seconds);
        }

        static void LongTimeProess()
        {
            Thread.Sleep(3000);
        }
        static bool IsEmail(string emial)
        {
            Regex regex = new Regex(@"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)
*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");
        }
    }
}
