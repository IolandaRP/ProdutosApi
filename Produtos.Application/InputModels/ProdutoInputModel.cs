using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Application.InputModels
{
    public class ProdutoInputModel
    {
        public ProdutoInputModel(string descricao, decimal valorUnitario, DateTime dataExclusao)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            DataExclusao = dataExclusao;
        }
        public String Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public DateTime DataExclusao { get; set; }
    }
}
