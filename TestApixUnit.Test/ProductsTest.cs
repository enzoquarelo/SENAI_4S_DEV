using API_para_estudos_com_xUnit.Controllers;
using API_para_estudos_com_xUnit.Domains;
using API_para_estudos_com_xUnit.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NuGet.Protocol.Core.Types;

namespace TestApixUnit.Test
{
    public class ProductsTest
    {
        //Indica que o método é de teste de unidade
        [Fact]
        public void Get()
        {
            var products = new List<Products>
            {
                new Products
                {
                    IdProduto = Guid.NewGuid(),
                    Nome = "Produto 1",
                    Preco = 99
                },
                new Products
                {
                    IdProduto = Guid.NewGuid(),
                    Nome = "Produto 2",
                    Preco = 10
                }
            };

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(p => p.Listar()).Returns(products);


            var result = mockRepository.Object.Listar();


            Assert.Equal(2, result.Count);
        }

    }
}