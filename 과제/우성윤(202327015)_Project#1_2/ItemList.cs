using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using 우성윤_202327015__Project_1;

namespace 우성윤_202327015__Project_1
{
    public class ItemList
    {
        private List<Item> items;
        public decimal TotalPrice { get; private set; }

        public ItemList()
        {
            items = new List<Item>();
            TotalPrice = 0;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            TotalPrice += item.Price;
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
            Console.WriteLine($"Total Price: {TotalPrice:C}");
        }

        // CSV 파일에서 아이템 로드
        public void LoadItemsFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Context.RegisterClassMap<ItemMap>();
                var records = new List<Item>();
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var description = csv.GetField("Description");
                    var price = csv.GetField<decimal>("Price");
                    var sku = csv.GetField("Sku");
                    var expirationDateStr = csv.GetField("ExpirationDate");
                    var typeStr = csv.GetField("Type");

                    if (!string.IsNullOrEmpty(expirationDateStr))
                    {
                        var expirationDate = DateTime.Parse(expirationDateStr);
                        var groceryItem = new GroceryItem(description, price, sku, expirationDate);
                        records.Add(groceryItem);
                    }
                    else if (!string.IsNullOrEmpty(typeStr))
                    {
                        if (Enum.TryParse(typeStr, out ApplianceType type))
                        {
                            var applianceItem = new ApplianceItem(description, price, sku, type);
                            records.Add(applianceItem);
                        }
                    }
                    else
                    {
                        var genericItem = new GroceryItem(description, price, sku, DateTime.MinValue); // ExpirationDate가 없는 경우 기본값 설정
                        records.Add(genericItem);
                    }
                }

                foreach (var record in records)
                {
                    AddItem(record);
                }
            }
        }

        // 결과를 파일로 저장하는 메서드
        public void SaveItemsToFile(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var item in items)
                {
                    writer.WriteLine(item.GetDisplayInfo());
                }
                writer.WriteLine($"Total Price: {TotalPrice:C}");
            }
        }
    }

    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Map(m => m.Description).Name("Description");
            Map(m => m.Price).Name("Price");
            Map(m => m.Sku).Name("Sku");
            Map(m => ((GroceryItem)m).ExpirationDate).Name("ExpirationDate").Optional();
            Map(m => ((ApplianceItem)m).Type).Name("Type").Optional();
        }
    }
}
