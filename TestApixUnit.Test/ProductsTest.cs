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
        //Indica que o método é de teste de listagem
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

        //Indica que o método é de teste de cadastro
        [Fact]
        public void Post()
        {
            var newProduct = new Products
            {
                IdProduto = Guid.NewGuid(),
                Nome = "Produto 1",
                Preco = 99
            };

            var productList = new List<Products>(s);
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(p => p.Cadastrar(newProduct)).Callback<Products>(p=> productList.Add(newProduct));

            mockRepository.Object.Cadastrar(newProduct);

            Assert.Contains(newProduct, productList);
        }

        //Indica que o método é de teste de delete
        [Fact]
        public void Delete()
        {
            var productId = Guid.NewGuid();

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(p => p.Deletar(productId));

            mockRepository.Object.Deletar(productId);

            mockRepository.Verify(p => p.Deletar(productId));
        }

        [Fact]
        public void GetById()
        {
            var productId = Guid.NewGuid();
            var product = new Products
            {
                IdProduto = productId,
                Nome = "Produto 1",
                Preco = 99
            };

            var mockRepository = new Mock<IProductsRepository>();
            mockRepository.Setup(p => p.ListarPorId(productId)).Returns(product);

            var controller = new Products(mockRepository.Object);

            // Act
            var result = controller(productId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnProduct = Assert.IsType<Products>(okResult.Value);

            Assert.Equal(productId, returnProduct.IdProduto);
            Assert.Equal("Produto 1", returnProduct.Nome);
            Assert.Equal(99, returnProduct.Preco);
        }

        [Fact]
        public void Put()
        {
            var existingProduct = new Products
            {
                IdProduto = Guid.NewGuid(),
                Nome = "Produto Antigo",
                Preco = 50
            };

            var updatedProduct = new Products
            {
                IdProduto = existingProduct.IdProduto,
                Nome = "Produto Novo",
                Preco = 100
            };

            var productList = new List<Products> { existingProduct };
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(p => p.Listar()).Returns(productList);

            mockRepository.Setup(p => p.Atualizar(updatedProduct)).Callback(() =>
            {
                var productToUpdate = productList.FirstOrDefault(p => p.IdProduto == updatedProduct.IdProduto);
                if (productToUpdate != null)
                {
                    productToUpdate.Nome = updatedProduct.Nome;
                    productToUpdate.Preco = updatedProduct.Preco;
                }
            });

            mockRepository.Object.Atualizar(updatedProduct);

            // Assert
            var updatedProductFromRepo = productList.FirstOrDefault(p => p.IdProduto == existingProduct.IdProduto);
            Assert.NotNull(updatedProductFromRepo);
            Assert.Equal("Produto Atualizado", updatedProductFromRepo.Nome);
            Assert.Equal(100, updatedProductFromRepo.Preco);
        }
    }
}