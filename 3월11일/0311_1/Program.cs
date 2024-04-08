using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0311_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력진수를 결정하세요 (16/10/2) : ");
            string inputChoice = Console.ReadLine();

            if (inputChoice == "16")
            {
                Console.Write("16진수를 입력하세요:");
                int a = Console.Read();
                string hexValue = Console.ReadLine();
                int decimalValue = Convert.ToInt32(hexValue, 16);
                Console.WriteLine($"2진수: {Convert.ToString(decimalValue, 2)}");
                Console.WriteLine($"10진수: {decimalValue}");
            }
            else if (inputChoice == "10")
            {
                Console.Write("10진수를 입력하세요:");
                int decimalValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"2진수: {Convert.ToString(decimalValue, 2)}");
                Console.WriteLine($"16진수: {Convert.ToString(decimalValue, 16)}");
            }
            else if (inputChoice == "2")
            {
                Console.Write("2진수를 입력하세요:");
                string binaryValue = Console.ReadLine();
                int decimalValue = Convert.ToInt32(binaryValue, 2);
                Console.WriteLine($"10진수: {decimalValue}");
                Console.WriteLine($"16진수: {Convert.ToString(decimalValue, 16)}");
            }
            else
            {
                Console.WriteLine("올바른 옵션을 선택하세요.");
            }
        }
    }
}
