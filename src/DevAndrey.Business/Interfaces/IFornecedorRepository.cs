using System;
using System.Threading.Tasks;
using DevAndrey.Business.Interfaces;
using DevAndrey.Business.Models;

namespace DevAndrey.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}