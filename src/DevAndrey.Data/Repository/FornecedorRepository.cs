using System;
using System.Threading.Tasks;
using DevAndrey.Business.Interfaces;
using DevAndrey.Business.Models;
using DevAndrey.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevAndrey.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MyDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Produtos)
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}