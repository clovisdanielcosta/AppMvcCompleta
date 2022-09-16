using AppMvcBasica.Models;

namespace CD.Business.Interfaces
{
    internal interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(int fornecedorId);
    }
}
