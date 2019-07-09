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

        public List<Produto> Listar()
        {
            produtos.Add(new Produto { ProdutoId=Guid.NewGuid(), Nome ="Maracuja", Quantidade= 12, Valor= 14, DataVencimento = DateTime.Now.AddDays(15)});
            produtos.Add(new Produto { ProdutoId=Guid.NewGuid(), Nome ="Banana", Quantidade= 112, Valor= 2, DataVencimento = DateTime.Now.AddDays(12)});
            produtos.Add(new Produto { ProdutoId=Guid.NewGuid(), Nome ="Maça", Quantidade= 2, Valor= 25, DataVencimento = DateTime.Now.AddDays(15)});
            produtos.Add(new Produto { ProdutoId=Guid.NewGuid(), Nome ="Uva", Quantidade= 115, Valor= 4, DataVencimento = DateTime.Now.AddDays(7)});
            return produtos;
        }
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

    }
}
