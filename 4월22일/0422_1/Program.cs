using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0422_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int i = 0;
            //string s = null;
            //s = "안녕하세요.";
            //string empty = "";

            //Console.WriteLine(i);
            //Console.WriteLine(s);
            //Console.WriteLine(empty);

            //2
            //string s = null; Console.WriteLine(s);

            //int? ii = null; Console.WriteLine(ii);
            //double? d = null; Console.WriteLine(d);

            //Nullable<int> i = null; Console.WriteLine(i);
            //Nullable<double> dd = null; Console.WriteLine(dd);

            //3
            //string nullValue = null;
            //string message = "";

            //nullValue = null;
            //if(nullValue == null) { message = "[1] null 이면 새로운 값으로 초기화 합니다."; }
            //Console.WriteLine(message);

            //nullValue = null;
            //message = nullValue ?? "[2] null이면 새로운 값으로 초기화 합니다.";
            //Console.WriteLine(message);

            //4

            //var result = "";
            //var message = "";

            //message = null;
            //result = message ?? "기본값";
            //Console.WriteLine(result);

            //message = "있는값";
            //result = message ?? "기본값";
            //Console.WriteLine(result);

            //5
            //int? value = null;
            //int defaultValue = value ?? -1;
            //Console.WriteLine(defaultValue);

            //6
            //bool? unknown = null;
            //if (unknown ?? true)
            //    Console.WriteLine("출력됨");

            //unknown = false;
            //if (!unknown ?? false)
            //    Console.WriteLine("출력됨");

            //7
            List<string> list = null;
            int? numberOfList;

            numberOfList = list?.Count;
            if(numberOfList == null)
            {
                Console.WriteLine($"[1]리스트 카운트 : null");
            }
            list = new List<string>();
            list.Add("안녕하세요."); list.Add("반갑습니다.");

            numberOfList = list?.Count;
            if (numberOfList!=null)
            {
                Console.WriteLine($"[2]리스트 카운트 : {numberOfList}");    
            }
        }
    }
}
