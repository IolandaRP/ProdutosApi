using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Application.InputModels
{
    public class UpdateProdutoInputModel
    {
        public UpdateProdutoInputModel(int produtoId, string descricao, decimal valorUnitario)
        {
            this.ProdutoId = produtoId;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
        }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
