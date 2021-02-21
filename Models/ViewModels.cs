using System.Collections.Generic;

namespace Shop.Models
{
    public class ProductView
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Describe { get; set; }
        public double Price { get; set; }
        public string IdType {get; set; }
        public string ImgLink {get; set; }
        public string Origin {get; set; }
    }

    public class TypeProduct
    {
        public string ID {get; set; }
        public string TypeName {get; set; }
    }
}