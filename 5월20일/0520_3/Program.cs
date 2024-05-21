using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0520_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Temp\\Test.txt";

            if (File.Exists(file))
            {
                Console.WriteLine("{0}", File.GetCreationTime(file));
                File.Copy(file, "C:\\Temp\\Test2.txt", true);
            }

            FileInfo fi = new FileInfo(file);
            if( fi.Exists)
            {
                Console.WriteLine($"{fi.FullName}");
            }
        }
    }
}
