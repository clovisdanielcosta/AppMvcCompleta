using AppMvcBasica.Models;
using AppMvcBasica.ViewModels;
using AutoMapper;

namespace CD.App.AutoMapper
{
    public class AutoMaperConfig : Profile
    {
        public AutoMaperConfig()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
