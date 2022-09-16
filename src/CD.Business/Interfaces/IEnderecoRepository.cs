using AppMvcBasica.Models;

namespace CD.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(int fornecedorId);
    }
}
