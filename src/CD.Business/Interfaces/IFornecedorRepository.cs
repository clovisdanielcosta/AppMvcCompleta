using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business.Interfaces
{
    internal interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid Id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid Id);
    }
}
