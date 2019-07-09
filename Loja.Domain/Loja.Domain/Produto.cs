using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Domain
{
    public class Produto
    {
        private List<Produto> produtos;

        public Produto()
        {
            produtos = new List<Produto>();
        }

        public List<Produto> ListarFrutas()
        {
            produtos.Add(new Produto { Nome = "Maracuja", Valor = 14, Categoria = "frutas" });
            produtos.Add(new Produto { Nome = "Banana", Valor = 2, Categoria = "frutas" });
            produtos.Add(new Produto { Nome = "Maça", Valor = 25, Categoria = "frutas" });
            produtos.Add(new Produto { Nome = "Uva", Valor = 4, Categoria = "frutas" });
            return produtos;
        }

        public List<Produto> ListarEletronicos()
        {
            produtos.Add(new Produto { Nome = "Maracuja", Valor = 14, Categoria = "eletronicos" });
            produtos.Add(new Produto { Nome = "Banana", Valor = 2, Categoria = "eletronicos" });
            produtos.Add(new Produto { Nome = "Maça", Valor = 25, Categoria = "eletronicos" });
            produtos.Add(new Produto { Nome = "Uva", Valor = 4, Categoria = "eletronicos" });
            return produtos;
        }

        public string Nome { get; set; }

        public decimal Valor { get; set; }
        public string Categoria { get; set; }


    }
}
