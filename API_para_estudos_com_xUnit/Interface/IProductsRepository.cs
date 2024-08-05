using API_para_estudos_com_xUnit.Domains;

namespace API_para_estudos_com_xUnit.Interface
{
    public interface IProductsRepository
    {
        void Cadastrar(Products produto);
        void Deletar(Guid id);
        List<Products> Listar();
        List<Products> ListarPorId(Guid id);
        void Atualizar(Guid id, Products produto);
    }
}
