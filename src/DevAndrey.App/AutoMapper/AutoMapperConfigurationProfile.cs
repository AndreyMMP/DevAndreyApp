using AutoMapper;
using DevAndrey.App.ViewModels;
using DevAndrey.Business.Models;

namespace DevAndrey.App.AutoMapper
{
    public class AutoMapperConfigurationProfile : Profile
    {
        public AutoMapperConfigurationProfile()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, FornecedorViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
