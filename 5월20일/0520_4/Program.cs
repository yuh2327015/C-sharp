using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0520_4
{
    public class Record
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string AuthCode { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
                System.IO.File.ReadAllLines(@"C:\Temp\Src.txt", System.Text.Encoding.UTF8);
            foreach ( var line in lines )
            {
                Console.WriteLine (line);
            }
            List<Record> records = new List<Record>();
            foreach (var line in lines)
            {
                string[] splitData = line.Split(',');
                records.Add(
                    new Record
                    {
                        Name = splitData[0],
                        PhoneNumber = splitData[1],
                        BirthDate = Convert.ToDateTime(splitData[2]),
                        AuthCode = splitData[3]
                    });
            }

            Console.WriteLine(records[0]?.Name ?? "데이터가 없습니다.");
        }
    }
}
