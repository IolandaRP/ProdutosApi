using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(string descricao, decimal valorUnitario)
        {
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
        }
        public string descricao { get; set; }
        public decimal valorUnitario { get; set; }
    }
}
