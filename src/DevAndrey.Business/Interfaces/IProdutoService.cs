using System;
using System.Threading.Tasks;
using DevAndrey.Business.Models;

namespace DevAndrey.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}