using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using otavio_877229_persistencia_dados.Context;
using otavio_877229_persistencia_dados.Models;

namespace otavio_877229_persistencia_dados.Controllers
{
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ListarProdutos()
        {
            var produtos = _context.Produtos.ToList();

            return produtos != null ? produtos : NotFound("Produtos não encontrados...");
        }

        [HttpGet]
        [Route("{id:int}", Name = "ObterProduto")]
        public ActionResult<Produto> ListarProdutoPorId(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

            return produto != null ? produto : NotFound("Produto não encontrado...");
        }

        [HttpPost]
        public ActionResult CadastrarProduto(Produto produto)
        {
            if (produto is null)
                BadRequest();

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult<Produto> AlterarInformacoes(int id, Produto produto)
        {
            if (id != produto?.ProdutoId)
                return BadRequest("Produto não encontrado na base de dados...");

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult<Produto> DeletarProduto(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto is null)
                return NotFound("Produto não encontrado na base de dados");

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return produto;
        }
    }
}