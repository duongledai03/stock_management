using System;

namespace StockManagement
{
    public class StockItem
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int QuantityInStock { get; private set; }

        public StockItem(int code, string name, int quantity)
        {
            if (code <= 0)
                throw new ArgumentException("Item code must be a positive integer. ");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Item name cannot be blank. ");

            if (quantity <= 0)
                throw new ArgumentException("Quantity cannot be zero or negative. ");

            Code = code;
            Name = name;
            QuantityInStock = quantity;
        }

        public void AddQuantity(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity cannot be negative");

            QuantityInStock += quantity;
        }

        public void SubtractQuantity(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity cannot be negative");

            if (quantity > QuantityInStock)
                throw new Exception("Insufficient quantity in stock");

            QuantityInStock -= quantity;
        }
    }
}
