using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "내가 그의 이름을 불러주기 전에는 그는 다만 하나의 몸짓에 지나지 않았다.\n";
            inputString += "내가 그의 이름을 불러주었을 때, 그는 내게로 와 꽃이 되었다.\n";
            inputString += "내가 그의 이름을 불러준 것처럼 나의 이 빛깔과 향기에 알맞는 누가 나의 이름을 불러다오.\n";
            inputString += "그에게로 가서 나도 그의 꽃이 되고 싶다.\n";
            inputString += "우리들은 모두 무엇이 되고 싶다.\n";
            inputString += "나는 너에게 너는 나에게 잊혀지지 않는 하나의 눈짓이 되고 싶다.";

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Count character occurrences
            foreach (char character in inputString)
            {
                if (charCounts.ContainsKey(character))
                    charCounts[character]++;
                else
                    charCounts[character] = 1;
            }

            // Find character with minimum occurrence
            KeyValuePair<char, int> minCharCount = charCounts.OrderBy(x => x.Value).First();

            Console.WriteLine("==============================================================================");
            Console.WriteLine(inputString);
            Console.WriteLine("==============================================================================");
            Console.WriteLine($"가장 적게 나온 문자는 [{minCharCount.Key}]이며, 횟수는 {minCharCount.Value}번 입니다.");
        }
    }
}
