using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Product
    {
        public int Id { get; set; }
        public ProductCategory Category { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
        public string? Functional { get; set; }
        public decimal? PriceWholesale { get; set; }
        public decimal? PriceRetail { get; set; }
        public string? Producer { get; set; }
        public AccessibilityType Accessibility { get; set; }
        public File? Documentation { get; set; }
        public File? Video { get; set; }
        public List<File>? Images { get; set; }
        public List<Product>? Subproducts { get; set; }
    }

    public enum AccessibilityType
    {
        None = 0,
        Request = 1,
    }

    public enum ProductCategory
    {
        [Description("Продукты на основе «СМИС»")]
        Monitoring = 1,
        [Description("Продукты на основе «Продукта»")]
        Product = 2,
    }
}
