﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace _0603_1
{
    internal class Program
    {
        private static void Ide()
        { 
            Thread.Sleep(3000);
            Console.WriteLine("[3]IDE:Visual Studio");
        }
        private static void Sql()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[2]DBMS:SQL Server");
        }
        private static void Win()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[1]OS:Windows Server");
        }
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(Win);
            ThreadStart ts2 = new ThreadStart(Sql);
            Thread t1 = new Thread(ts1);
            var t2 = new Thread(ts2);
            var t3 = new Thread(new ThreadStart(Ide))
            {
                Priority = ThreadPriority.Highest
            };
            t1.Start();
            t2.Start();
            t3.Start();

            Process.Start("IExplore.exe");
            Process.Start("Notepad.exe");
        }
    }
}
