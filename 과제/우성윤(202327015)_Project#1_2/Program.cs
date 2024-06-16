using System;
using 우성윤_202327015__Project_1;

namespace 우성윤_202327015__Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemList itemList = new ItemList();

            // CSV 파일 경로
            string csvFilePath = "items.csv";
            string resultFilePath = "Result.txt";

            // CSV 파일에서 아이템 로드
            itemList.LoadItemsFromCsv(csvFilePath);

            // 항목 정보 출력
            itemList.DisplayItems();

            // 결과를 파일로 저장
            itemList.SaveItemsToFile(resultFilePath);

            Console.WriteLine($"Results saved to {resultFilePath}");
        }
    }
}
