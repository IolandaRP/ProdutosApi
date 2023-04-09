using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Core.Entities
{
    public class Produto
    {
        public int ProdutoId { get; private set; }
        public string Descricao { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public DateTime DataExclusao { get; private set; }

        public Produto(int produtoId, string descricao, decimal valorUnitario, DateTime dataExclusao)
        {
            ProdutoId = produtoId;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            DataExclusao = dataExclusao;
        }

        public void Update(string descricao, decimal valorUnitario)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
        }
    }
}
