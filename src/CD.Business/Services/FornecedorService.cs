using CD.Business.Interfaces;
using CD.Business.Models;
using CD.Business.Models.Validations;

namespace CD.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                && !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}
