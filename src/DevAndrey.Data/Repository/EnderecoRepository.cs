using System;
using System.Threading.Tasks;
using DevAndrey.Business.Interfaces;
using DevAndrey.Business.Models;
using DevAndrey.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevAndrey.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MyDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}