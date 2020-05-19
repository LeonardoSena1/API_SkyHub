using API_SkyHub.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static API_SkyHub.Models.POST_ProdutosCompleto;

namespace API_SkyHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //InserirProdutoCompleto();
            //InserirProdutoSimples();
            //AlteracaoCabecario();
            //CriarPedidoStatusNew();
            //AprovarStatusPedido();
            //Pedido_Enviado();
        }

        public static string InserirProdutoCompleto()
        {
            POST_ProdutosCompleto.RootObjets bodysend = new POST_ProdutosCompleto.RootObjets();
            bodysend.product = new POST_ProdutosCompleto.Product();

            bodysend.product.sku = "350";
            bodysend.product.name = "Teclado";
            bodysend.product.description = "Teclado comum";
            bodysend.product.status = "enabled";
            bodysend.product.price = 70;
            bodysend.product.promotional_price = 69.9;
            bodysend.product.cost = 0;
            bodysend.product.weight = 0.1;
            bodysend.product.height = 20;
            bodysend.product.width = 30;
            bodysend.product.length = 20;
            bodysend.product.brand = "Dell";
            bodysend.product.nbm = "";
            bodysend.product.categories = new List<Category>();

            var categoria = new Category();
            categoria.code = "01";
            categoria.name = "Eletronicos > Computadores > Componentes";
            bodysend.product.categories.Add(categoria);

            bodysend.product.images = new List<string>();
            var imagem = "http://d26lpennugtm8s.cloudfront.net/stores/154/284/products/camiseta-lisa-verde-bandeira-algodo-p-ao-gg-pronta-entrega-355901-mlb20431777049_092015-o-07fadec89e5ed54705c1b9ab5411dec8-1024-1024.jpg";
            bodysend.product.images.Add(imagem);

            bodysend.product.specifications = new List<Specification>();
            var especificacao = new Specification();
            especificacao.key = "Especicações do Produto PAI";
            especificacao.value = "Especificações do Produto PAI";
            bodysend.product.specifications.Add(especificacao);

            bodysend.product.variations = new List<Variation>();
            var variacao = new Variation();
            variacao.sku = "COD_SKU_VARIACAO";
            variacao.qty = 10;
            variacao.ean = "9876543210987";
            variacao.images = new List<string>();
            var imagen = "http://d26lpennugtm8s.cloudfront.net/stores/154/284/products/camiseta-lisa-verde-bandeira-algodo-p-ao-gg-pronta-entrega-355901-mlb20431777049_092015-o-07fadec89e5ed54705c1b9ab5411dec8-1024-1024.jpg";
            variacao.images.Add(imagen);
            variacao.specifications = new List<Specification>();
            var especificacaoVariacao = new Specification();
            especificacaoVariacao.key = "Cor";
            especificacaoVariacao.value = "Verde";
            variacao.specifications.Add(especificacaoVariacao);
            var espefificacaoVariacao1 = new Specification();
            espefificacaoVariacao1.key = "Tamanho";
            espefificacaoVariacao1.value = "M";
            variacao.specifications.Add(espefificacaoVariacao1);
            bodysend.product.variations.Add(variacao);

            bodysend.product.variation_attributes = new List<string>();
            var cor = "Cor";
            bodysend.product.variation_attributes.Add(cor);
            var tamanho = "Tamanho";
            bodysend.product.variation_attributes.Add(tamanho);

            var client = new RestClient("https://api.skyhub.com.br/products");
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-User-Email", "benjamim@srmidia.com.br");
            request.AddHeader("x-Api-Key", "kKkPwJKVpSRg7mNF93dM");
            request.AddHeader("x-accountmanager-key", "vd4MLTDndq");
            request.AddHeader("Accept", "application/json;charset=UTF-8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,text/plain", JsonConvert.SerializeObject(bodysend, Newtonsoft.Json.Formatting.None,
                                                                                            new JsonSerializerSettings
                                                                                            {
                                                                                                NullValueHandling = NullValueHandling.Ignore
                                                                                            }), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }

        public static string InserirProdutoSimples()
        {
            var bodySend = new Models.POST_ProdutoSimples.RootObjets();
            bodySend.product = new POST_ProdutoSimples.Product();

            bodySend.product.sku = "500";
            bodySend.product.name = "PRODUTO SIMPLES";
            bodySend.product.description = "PRODUTO SIMPLES";
            bodySend.product.status = "enabled";
            bodySend.product.qty = 0;
            bodySend.product.price = 100;
            bodySend.product.promotional_price = 89.99;
            bodySend.product.cost = 49;
            bodySend.product.weight = 3;
            bodySend.product.height = 1;
            bodySend.product.width = 1;
            bodySend.product.length = 1;
            bodySend.product.brand = "SKYHUB";
            bodySend.product.ean = "";
            bodySend.product.nbm = "";

            bodySend.product.categories = new List<Models.POST_ProdutoSimples.Category>();
            var Cate = new Models.POST_ProdutoSimples.Category();
            Cate.code = "01";
            Cate.name = "skyhub homologação";
            bodySend.product.categories.Add(Cate);

            bodySend.product.images = new List<string>();
            var image = "";
            bodySend.product.images.Add(image);


            bodySend.product.specifications = new List<Models.POST_ProdutoSimples.Specification>();
            var specificacao = new Models.POST_ProdutoSimples.Specification();
            specificacao.key = "Tamanho";
            specificacao.value = "M";
            bodySend.product.specifications.Add(specificacao);




            var client = new RestClient("https://api.skyhub.com.br/products");
            client.Timeout = -1;
            client.FollowRedirects = false;
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-User-Email", "benjamim@srmidia.com.br");
            request.AddHeader("x-Api-Key", "kKkPwJKVpSRg7mNF93dM");
            request.AddHeader("x-accountmanager-key", "vd4MLTDndq");
            request.AddHeader("Accept", "application/json;charset=UTF-8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,text/plain", JsonConvert.SerializeObject(bodySend, Newtonsoft.Json.Formatting.None,
                                                                                            new JsonSerializerSettings
                                                                                            {
                                                                                                NullValueHandling = NullValueHandling.Ignore
                                                                                            }), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }

        public static string AlteracaoCabecario()
        {
            string sku_Pedido = "200";

            var bodySend = new PUT_Cabecario_Produto.RootObjets();
            bodySend.product = new PUT_Cabecario_Produto.Product();
            bodySend.product.name = "PUT C#";
            bodySend.product.qty = 3;
            bodySend.product.price = 20;
            bodySend.product.promotional_price = 19.9;


            var client = new RestClient("https://api.skyhub.com.br/products/" + $"{sku_Pedido}");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("X-User-Email", "benjamim@srmidia.com.br");
            request.AddHeader("x-Api-Key", "kKkPwJKVpSRg7mNF93dM");
            request.AddHeader("x-accountmanager-key", "vd4MLTDndq");
            request.AddHeader("Accept", "application/json;charset=UTF-8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,text/plain", JsonConvert.SerializeObject(bodySend, Newtonsoft.Json.Formatting.None,
                                                                                            new JsonSerializerSettings
                                                                                            {
                                                                                                NullValueHandling = NullValueHandling.Ignore
                                                                                            }), ParameterType.RequestBody); ;
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }

        public static string CriarPedidoStatusNew()
        {
            var bodySend = new Models.POST_CriarPedidoStatusNew.RootObjects();
            bodySend.order = new POST_CriarPedidoStatusNew.Order();
            bodySend.order.channel = "Americanas";
            bodySend.order.items = new List<Models.POST_CriarPedidoStatusNew.Item>();
            var item = new Models.POST_CriarPedidoStatusNew.Item();
            item.id = "350";
            item.qty = 1;
            item.original_price = 70.0;
            item.special_price = 69.9;
            bodySend.order.items.Add(item);

            bodySend.order.customer = new Models.POST_CriarPedidoStatusNew.Customer();
            bodySend.order.customer.name = "Leonardo Sena";
            bodySend.order.customer.email = "leonardo_sena1@hotmail.com";
            bodySend.order.customer.date_of_birth = "1996-04-10";
            bodySend.order.customer.gender = "male";
            bodySend.order.customer.vat_number = "12312312309";
            bodySend.order.customer.phones = new List<string>();
            var celular = "11930104128";
            bodySend.order.customer.phones.Add(celular);

            bodySend.order.billing_address = new POST_CriarPedidoStatusNew.BillingAddress();
            bodySend.order.billing_address.street = "Rua Teste C#";
            bodySend.order.billing_address.number = 6420;
            bodySend.order.billing_address.detail = "Ponto de referencia teste";
            bodySend.order.billing_address.city = "Guarulhos";
            bodySend.order.billing_address.region = "UF";
            bodySend.order.billing_address.country = "BR";
            bodySend.order.billing_address.postcode = "9000000";

            bodySend.order.shipping_address = new POST_CriarPedidoStatusNew.ShippingAddress();
            bodySend.order.shipping_address.street = "Rua Teste C#";
            bodySend.order.shipping_address.number = 6420;
            bodySend.order.shipping_address.detail = "Ponto de referencia teste";
            bodySend.order.shipping_address.city = "Guarulhos";
            bodySend.order.shipping_address.region = "UF";
            bodySend.order.shipping_address.country = "BR";
            bodySend.order.shipping_address.postcode = "9000000";

            bodySend.order.shipping_method = "Transportadora";
            bodySend.order.estimated_delivery = "2020-06-26";
            bodySend.order.shipping_cost = 5;
            bodySend.order.interest = 0;
            bodySend.order.discount = 0;

            var client = new RestClient("https://api.skyhub.com.br/orders ");
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-User-Email", "benjamim@srmidia.com.br");
            request.AddHeader("x-Api-Key", "kKkPwJKVpSRg7mNF93dM");
            request.AddHeader("x-accountmanager-key", "vd4MLTDndq");
            request.AddHeader("Accept", "application/json;charset=UTF-8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,text/plain", JsonConvert.SerializeObject(bodySend, Newtonsoft.Json.Formatting.None,
                             new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }

        public static string AprovarStatusPedido()
        {
            string canal = "Americanas";
            string codigo = "1589914839137";

            var status = new POST_AprovarPedidoStatus.RootObjects();
            status.status = "payment_received";

            var client = new RestClient("https://api.skyhub.com.br/orders/" + $"{canal}" + "-" + $"{codigo}/approval");
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-User-Email", "benjamim@srmidia.com.br");
            request.AddHeader("x-Api-Key", "kKkPwJKVpSRg7mNF93dM");
            request.AddHeader("x-accountmanager-key", "vd4MLTDndq");
            request.AddHeader("Accept", "application/json;charset=UTF-8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,text/plain", JsonConvert.SerializeObject(status, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }

        public static string Pedido_Enviado()
        {
            string canal = "Americanas";
            string codigo = "1589914839137";

            var bodySend = new Models.POST_PedidoEnviado.RootObjects();
            bodySend.status = "order_shipped";
            bodySend.shipment = new POST_PedidoEnviado.Shipment();
            bodySend.shipment.code = $"{canal}-{codigo}";
            bodySend.shipment.delivered_carrier_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK"));
            bodySend.shipment.items = new List<Models.POST_PedidoEnviado.Item>();
            var item = new Models.POST_PedidoEnviado.Item();
            item.sku = "350";
            item.qty = 1;
            bodySend.shipment.items.Add(item);

            bodySend.shipment.track = new POST_PedidoEnviado.Track();
            bodySend.shipment.track.code = "BR1321830198302DR";
            bodySend.shipment.track.carrier = "Correios";
            bodySend.shipment.track.method = "SEDEX";
            bodySend.shipment.track.url = "www.correios.com.br";

            var client = new RestClient("https://api.skyhub.com.br/orders/" + $"{canal}" + "-" + $"{codigo}/shipments");
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-User-Email", "benjamim@srmidia.com.br");
            request.AddHeader("x-Api-Key", "kKkPwJKVpSRg7mNF93dM");
            request.AddHeader("x-accountmanager-key", "vd4MLTDndq");
            request.AddHeader("Accept", "application/json;charset=UTF-8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,text/plain", JsonConvert.SerializeObject(bodySend, Newtonsoft.Json.Formatting.None,
                              new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return string.Empty;
        }
    }
}
