namespace API_SkyHub.Models
{
    public class PUT_Cabecario_Produto
    {
        public class Product
        {
            public string name { get; set; }
            public double price { get; set; }
            public int qty { get; set; }
            public double promotional_price { get; set; }
        }
        public class RootObjets
        {
            public Product product { get; set; }
        }
    }
}
