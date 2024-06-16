using System;
using System.Diagnostics;
using 우성윤_202327015__Project_1;

namespace 우성윤_202327015__Project_1
{
    public enum ApplianceType
    {
        Washer,
        Dryer,
        Dishwasher,
        Oven,
        Refrigerator
    }

    public class ApplianceItem : Item
    {
        public ApplianceType Type { get; set; }

        public ApplianceItem(string description, decimal price, string sku, ApplianceType type)
            : base(description, price, sku)
        {
            Type = type;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Appliance Item: {Description}, Price: {Price:C}, Sku: {Sku}, Type: {Type}");
        }

        public override string GetDisplayInfo()
        {
            return $"Appliance Item: {Description}, Price: {Price:C}, Sku: {Sku}, Type: {Type}";
        }
    }
}
