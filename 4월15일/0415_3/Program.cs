using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> data = new Dictionary<string, string>();

            data.Add("cs", "c#");
            data.Add("aspx", "ASP.NET");

            data.Remove("aspx");

            data["cshtml"] = "ASP.NET MVC";

            try
            {
                data.Add("cs", "CSharp");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (KeyValuePair<string, string> item in data) 
            { 
                Console.WriteLine("{0}은 {1}의 확장자 입니다.",item.Key,item.Value);
            }

            Console.WriteLine(data["cs"]);

            try
            {
                Console.WriteLine(data["vb"]);
            }
            catch (KeyNotFoundException knfe)
            { 
                Console.WriteLine(knfe.Message);
            }

            if (data.TryGetValue("cs",out var csharp))
            {
                Console.WriteLine(csharp);
            }
            else
            {
                Console.WriteLine("cs 키가 없습니다.");
            }
            
            if (!data.ContainsKey("json"))
            {
                data.Add("json", "JSON");
                Console.WriteLine(data["json"]);
            }

            var values = data.Values;
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
