using System;
using System.Threading.Tasks;
using DevAndrey.Business.Interfaces;
using DevAndrey.Business.Models;

namespace DevAndrey.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}