using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {


            //var produto = new Produto();

            //var pro = produto.Listar().Where(p => p.Valor>4);

            //foreach (var item in pro)
            //{
            //    Console.WriteLine(item.Nome);
            //}

            new Produto().Listar().Where(p => p.Valor>4 ).ToList().ForEach(item => {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.ProdutoId.ToString());

            });
            Console.ReadKey();

        }
    }
}
