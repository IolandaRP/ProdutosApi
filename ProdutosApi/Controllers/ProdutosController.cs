using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Produtos.Application.InputModels;
using Produtos.Application.Services;
using Produtos.Core.Entities;
using Produtos.Infrasctructure.Persistence;

namespace ProdutosApi.Controllers
{
        [Route("api/produtos")]
        public class ProdutosController : ControllerBase
        {
            private readonly IProdutoService _produtoService;
            public ProdutosController(IProdutoService produtoService)
            {
                _produtoService = produtoService;
                
            }

            //api/produtos?query=netcore
            [HttpGet]
            public IActionResult Get(string query)
            {
                var produtos = _produtoService.GetAll(query);
               
                return Ok(produtos);
            }

        //api/produtos/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = _produtoService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        //api/produtos
        [HttpPost]
        public IActionResult CreateProduto([FromBody] Produto inputModel)
        {
            if (inputModel.Descricao.Length > 255)
            {
                return BadRequest();
            }

            var id = _produtoService.CreateProduto(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        //api/produtos/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            _produtoService.Delete(id);

            return NoContent();

        }

        //api/produtos/id
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateProdutoInputModel inputModel)
        {
            inputModel.ProdutoId = id;

            var produto = GetById(inputModel.ProdutoId);

            if (produto == null)
            {
                return NotFound();
            }

            _produtoService.UpdateProduto(inputModel);

            return NoContent();
        }
    }
    }

