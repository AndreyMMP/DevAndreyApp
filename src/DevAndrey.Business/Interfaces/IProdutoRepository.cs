using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevAndrey.Business.Interfaces;
using DevAndrey.Business.Models;

namespace DevAndrey.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}