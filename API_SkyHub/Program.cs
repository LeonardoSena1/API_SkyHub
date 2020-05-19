﻿using API_SkyHub.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
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
    }
}