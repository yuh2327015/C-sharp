using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0520_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "안녕하세요.\r\n반갑습니다." + Environment.NewLine + "또 만나요123";

            StreamWriter sw = new StreamWriter("C:\\Temp\\Test.txt");

            sw.WriteLine(data);
            sw.Close();
            sw.Dispose();
        }
    }
}
