using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0513_4
{
    class SharedAndInstance
    {
        public static void StaticMember() => Console.WriteLine("[1]StaticMember");
        public void InstanceMember() => Console.WriteLine("[2] InstanceMember");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SharedAndInstance.StaticMember();
            SharedAndInstance obj = new SharedAndInstance();
            obj.InstanceMember();
        }
    }
}
