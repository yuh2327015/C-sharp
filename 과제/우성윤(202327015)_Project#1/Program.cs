using System;
using 우성윤_202327015__Project_1;

namespace 우성윤_202327015__Project_1
{
    class Program
    {
        //프로젝트 #1
        //제출자 : 우성윤(202327015)
        //제출일 : 2024.05.26
        static void Main(string[] args)
        {
            ItemList itemList = new ItemList();

            // CSV 파일 경로
            string filePath = "items.csv";

            // CSV 파일에서 아이템 로드
            itemList.LoadItemsFromCsv(filePath);

            // 항목 정보 출력
            itemList.DisplayItems();
        }
    }
}
