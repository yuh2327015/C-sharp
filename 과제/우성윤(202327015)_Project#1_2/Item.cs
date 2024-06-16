using System;

namespace 우성윤_202327015__Project_1
{
    public abstract class Item
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Sku { get; set; }

        public Item(string description, decimal price, string sku)
        {
            Description = description;
            Price = price;
            Sku = sku;
        }

        public abstract void DisplayInfo();

        public abstract string GetDisplayInfo();
    }
}
