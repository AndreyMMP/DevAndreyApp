using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevAndrey.App.ViewModels;

namespace DevAndrey.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DevAndrey.App.ViewModels.FornecedorViewModel> FornecedorViewModel { get; set; }
        public DbSet<DevAndrey.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
