using Loja.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aulas anteriores

            ////var produto = new Produto();

            ////var pro = produto.Listar().Where(p => p.Valor>4);

            ////foreach (var item in pro)
            ////{
            ////    Console.WriteLine(item.Nome);
            ////}

            //new Produto().Listar().Where(p => p.Valor>4 ).ToList().ForEach(item => {
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.ProdutoId.ToString());

            //});
            //var produtos = new Produto().Listar();
            //produtos = produtos.Where(p => p.Nome.Contains("a")).ToList();
            ////.Replace("a", "z") ´é possivel usar replace
            //var nomes = produtos.Where(p => p.DataVencimento.Day < 5)
            //    .Select(p => new {name = p.Nome, value =p.Valor, data =p.DataVencimento}).ToList();

            //foreach (var item in nomes)
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(item));
            //    Console.WriteLine(" ");

            //}

            //var valorMin = produtos.Where(x => x.Quantidade > 1).Average(x=>x.Valor);
            //var teste = produtos.Min(x => x.Valor).ToString();
            //foreach (var item in teste)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(valorMin);

            #endregion



            var produtosFrutas = new Produto().ListarFrutas();
            var produtosEletronicos = new Produto().ListarEletronicos();

            var produtos = new List<Produto>();
            produtos.AddRange(produtosFrutas);
            produtos.AddRange(produtosEletronicos);

            foreach (var item in produtos)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }
            
            var resultado = from p in produtos
                            
                            group p by p.Categoria into grupo
                            select new
                            {
                                NomDaCategoria = grupo.Key,
                                ValorMinimo = grupo.Min(x => x.Valor)
                            };

            foreach (var item in resultado)
            {
                Console.WriteLine("categoria" + item.NomDaCategoria);
                Console.WriteLine(item.ValorMinimo);
                Console.WriteLine(JsonConvert.SerializeObject(""+item));
            }

            Console.ReadKey();

        }
    }
}
