using GerenciadordeVendas.Models;
using GerenciadordeVendas.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _contexto;
        public ProdutoController(IProdutoRepository contexto)
        {
            this._contexto = contexto;
        }
        [HttpGet]
        [Route("getProdutos")]
        public IEnumerable<Produto> GetAllProducts()
        {
            var listProduto =  _contexto.GetAll();
            return listProduto;
        }
        [HttpPost]
        [Route("postProdutos")]
        public async Task<ActionResult<IEnumerable<Produto>>> PostProduct([FromBody] Produto produto)
        {
            await _contexto.Inserir(produto);
            return Ok(new {message = produto});
        }
    }
}
