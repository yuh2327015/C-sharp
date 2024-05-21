using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClassCode
{

}

namespace _0513_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassCode objectCode1 = new ClassCode();
            Console.WriteLine(objectCode1.GetHashCode());
            var objectCode2 = new ClassCode();
            Console.WriteLine(objectCode2.GetHashCode());
        }
    }
}
