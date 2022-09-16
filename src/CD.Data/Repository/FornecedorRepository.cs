using AppMvcBasica.Models;
using CD.Business.Interfaces;
using CD.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CD.Data.Repository
{
    internal class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext db) : base(db)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores
                .AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores
                .AsNoTracking()
                .Include(f => f.Produtos)
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
