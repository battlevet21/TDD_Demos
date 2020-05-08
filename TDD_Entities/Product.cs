using System;

namespace TDD_Entities
{
    public enum ProductCategory { Electronics, Laptops, Mobiles, Toys, Cloths, Other }
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
