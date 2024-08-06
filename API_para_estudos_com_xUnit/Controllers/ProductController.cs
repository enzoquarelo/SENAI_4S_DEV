using API_para_estudos_com_xUnit.Interface;
using API_para_estudos_com_xUnit.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_para_estudos_com_xUnit.Domains;
using NuGet.Protocol.Core.Types;

namespace API_para_estudos_com_xUnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IProductsRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpPost]
        public IActionResult Post(Products produto)
        {
            try
            {
                _productRepository.Cadastrar(produto);

                return StatusCode(201, produto);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<Products>> Get()
        {
            try
            {
                var products = _productRepository.Listar();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Products> Get(Guid id)
        {
            try
            {
                var product = _productRepository.ListarPorId(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _productRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
