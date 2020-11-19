using System;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Int16 CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 StockAmount { get; set; }
        public bool Status { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
