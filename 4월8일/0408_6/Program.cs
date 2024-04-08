using System;
using System.Collections.Generic;

namespace _0408_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inStr = "내가 그의 이름을 불러주기 전에는 그는 다만 하나의 몸짓에 지나지 않았다.\n";
            inStr += "내가 그의 이름을 불러주었을 때, 그는 내게로 와 꽃이 되었다.\n";
            inStr += "내가 그의 이름을 불러준 것처럼 나의 이 빛깔과 향기에 알맞는 누가 나의 이름을 불러다오.\n";
            inStr += "그에게로 가서 나도 그의 꽃이 되고 싶다.\n";
            inStr += "우리들은 모두 무엇이 되고 싶다.\n";
            inStr += "나는 너에게 너는 나에게 잊혀지지 않는 하나의 눈짓이 되고 싶다.";

            Console.WriteLine("==============================================================================");
            Console.WriteLine(inStr);
            Console.WriteLine("==============================================================================");

            while (true)
            {
                Console.Write("반복 횟수를 입력하시오. (0이면 종료): ");
                int repeatCount = int.Parse(Console.ReadLine());

                if (repeatCount == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }

                // 주어진 문자열에서 반복 횟수만큼 반복된 문자들을 찾고 출력합니다.
                FindRepeatedCharacters(inStr, repeatCount);

                Console.WriteLine("==============================================================================");
            }
        }

        // 주어진 문자열에서 입력값만큼 반복된 문자들을 찾고 출력하는 메서드
        static void FindRepeatedCharacters(string str, int repeatCount)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // 문자의 출현 횟수를 카운트합니다.
            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                    charCounts[c] = 1;
            }

            // 문자의 출현 횟수가 반복 횟수와 같은 경우 출력합니다.
            foreach (var pair in charCounts)
            {
                if (pair.Value == repeatCount)
                {
                    Console.WriteLine($"'{pair.Key}' 글자가 {repeatCount}회 나왔습니다.");
                }
            }
        }
    }
}
