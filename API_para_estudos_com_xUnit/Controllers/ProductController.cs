using API_para_estudos_com_xUnit.Interface;
using API_para_estudos_com_xUnit.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_para_estudos_com_xUnit.Domains;

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
    }
}
