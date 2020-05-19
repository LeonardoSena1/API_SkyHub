using System.Collections.Generic;

namespace API_SkyHub.Models
{
    public class POST_ProdutosCompleto
    {
        public class Category
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Specification
        {
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Variation
        {
            public string sku { get; set; }
            public int qty { get; set; }
            public string ean { get; set; }
            public IList<string> images { get; set; }
            public IList<Specification> specifications { get; set; }
        }

        public class Product
        {
            public string sku { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string status { get; set; }
            public double price { get; set; }
            public double promotional_price { get; set; }
            public double cost { get; set; }
            public double weight { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public int length { get; set; }
            public string brand { get; set; }
            public string nbm { get; set; }
            public IList<Category> categories { get; set; }
            public IList<string> images { get; set; }
            public IList<Specification> specifications { get; set; }
            public IList<Variation> variations { get; set; }
            public IList<string> variation_attributes { get; set; }
        }

        public class RootObjets
        {
            public Product product { get; set; }
        }
    }
}
