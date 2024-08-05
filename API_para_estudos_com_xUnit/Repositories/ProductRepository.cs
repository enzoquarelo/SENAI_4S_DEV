using API_para_estudos_com_xUnit.Context;
using API_para_estudos_com_xUnit.Domains;
using API_para_estudos_com_xUnit.Interface;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API_para_estudos_com_xUnit.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly Product_Context _context;

        public ProductRepository()
        {
            _context = new Product_Context();
        }

        public void Atualizar(Guid id, Products produto)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Products produto)
        {
            try
            {
                _context.Produtos.Add(produto);

                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Products> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Products> ListarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
