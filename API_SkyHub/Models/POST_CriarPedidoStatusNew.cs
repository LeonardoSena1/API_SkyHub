using System.Collections.Generic;

namespace API_SkyHub.Models
{
    public class POST_CriarPedidoStatusNew
    {
        public class Item
        {
            public string id { get; set; }
            public int qty { get; set; }
            public double original_price { get; set; }
            public double special_price { get; set; }
        }

        public class Customer
        {
            public string name { get; set; }
            public string email { get; set; }
            public string date_of_birth { get; set; }
            public string gender { get; set; }
            public string vat_number { get; set; }
            public IList<string> phones { get; set; }
        }

        public class BillingAddress
        {
            public string street { get; set; }
            public int number { get; set; }
            public string detail { get; set; }
            public string neighborhood { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public string postcode { get; set; }
        }

        public class ShippingAddress
        {
            public string street { get; set; }
            public int number { get; set; }
            public string detail { get; set; }
            public string neighborhood { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public string postcode { get; set; }
        }

        public class Order
        {
            public string channel { get; set; }
            public IList<Item> items { get; set; }
            public Customer customer { get; set; }
            public BillingAddress billing_address { get; set; }
            public ShippingAddress shipping_address { get; set; }
            public string shipping_method { get; set; }
            public string estimated_delivery { get; set; }
            public int shipping_cost { get; set; }
            public int interest { get; set; }
            public int discount { get; set; }
        }

        public class RootObjects
        {
            public Order order { get; set; }
        }
    }
}
