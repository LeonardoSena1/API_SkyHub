using System.Collections.Generic;

namespace API_SkyHub.Models
{
    class POST_ProdutoSimples
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

        public class Product
        {
            public string sku { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string status { get; set; }
            public int qty { get; set; }
            public int price { get; set; }
            public double promotional_price { get; set; }
            public int cost { get; set; }
            public int weight { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public int length { get; set; }
            public string brand { get; set; }
            public string ean { get; set; }
            public string nbm { get; set; }
            public IList<Category> categories { get; set; }
            public IList<string> images { get; set; }
            public IList<Specification> specifications { get; set; }
        }

        public class RootObjets
        {
            public Product product { get; set; }
        }
    }
}
