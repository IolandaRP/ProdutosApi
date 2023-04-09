using Produtos.Application.InputModels;
using Produtos.Application.ViewModels;
using Produtos.Core.Entities;
using Produtos.Infrasctructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly ProdutoDbContext _produtoDbContext;
        public ProdutoService(ProdutoDbContext produtoDbContext)
        {
            _produtoDbContext = produtoDbContext;
        }

        public List<ProdutoViewModel> GetAll(string query)
        {
            var produtos = _produtoDbContext.Produtos;

            var lista = new List<ProdutoViewModel>();

            lista = produtos
                .Select(p => new ProdutoViewModel(p.Descricao, p.ValorUnitario))
                .ToList();

            return lista;
        }

        public ProdutoViewModel GetById(int id)
        {
            var produto = _produtoDbContext.Produtos.SingleOrDefault(p => p.ProdutoId == id);

            if (produto == null)
                return null;

            var produtoViewModel = new ProdutoViewModel(produto.Descricao, produto.ValorUnitario);

            return produtoViewModel;
        }

        public int CreateProduto(Produto inputModel)
        {
            var produto = new Produto(inputModel.ProdutoId, inputModel.Descricao, inputModel.ValorUnitario, inputModel.DataExclusao);

            _produtoDbContext.Produtos.Add(produto);

            return produto.ProdutoId;
        }

        public void Delete(int id)
        {
            var produto = _produtoDbContext.Produtos.SingleOrDefault(p => p.ProdutoId == id);

            _produtoDbContext.Produtos.Remove(produto);
        }

        public void UpdateProduto(UpdateProdutoInputModel inputModel)
        {
            var produto = _produtoDbContext.Produtos.SingleOrDefault(p => p.ProdutoId == inputModel.ProdutoId);

            if (produto != null)
            {
                produto.Update(inputModel.Descricao, inputModel.ValorUnitario);
            }
        }
    }
}
