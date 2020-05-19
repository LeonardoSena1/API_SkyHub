using System;
using System.Collections.Generic;

namespace API_SkyHub.Models
{
    public class POST_PedidoEnviado
    {
        public class Item
        {
            public string sku { get; set; }
            public int qty { get; set; }
        }

        public class Track
        {
            public string code { get; set; }
            public string carrier { get; set; }
            public string method { get; set; }
            public string url { get; set; }
        }

        public class Shipment
        {
            public string code { get; set; }
            public DateTime delivered_carrier_date { get; set; }
            public IList<Item> items { get; set; }
            public Track track { get; set; }
        }

        public class RootObjects
        {
            public string status { get; set; }
            public Shipment shipment { get; set; }
        }
    }
}
