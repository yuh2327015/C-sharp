using System;
using System.Diagnostics;
using 우성윤_202327015__Project_1;

namespace 우성윤_202327015__Project_1
{
    public class GroceryItem : Item
    {
        public DateTime ExpirationDate { get; set; }

        public GroceryItem(string description, decimal price, string sku, DateTime expirationDate)
            : base(description, price, sku)
        {
            ExpirationDate = expirationDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Grocery Item: {Description}, Price: {Price:C}, Sku: {Sku}, Expiration Date: {ExpirationDate:d}");
        }
    }
}
