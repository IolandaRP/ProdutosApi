using Produtos.Application.InputModels;
using Produtos.Application.ViewModels;
using Produtos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Application.Services
{
    public interface IProdutoService
    {
            List<ProdutoViewModel> GetAll(string query);
            ProdutoViewModel GetById(int id);
            int CreateProduto(Produto inputModel);
            void Delete(int id);
            void UpdateProduto(UpdateProdutoInputModel inputModel);
        }
    }
