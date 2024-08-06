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
            try
            {
                Products produtoBuscado =  _context.Produtos.Find(id);

                _context.Produtos.Remove(produtoBuscado);

                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Products> Listar()
        {
            try
            {
                return _context.Produtos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar produtos", ex);
            }
        }

        public List<Products> ListarPorId(Guid id)
        {
            try
            {
                return _context.Produtos.Where(p => p.IdProduto == id).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar produto por ID", ex);
            }
        }
    }
}
