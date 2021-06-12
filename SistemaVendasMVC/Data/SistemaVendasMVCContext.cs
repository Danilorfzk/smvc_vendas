using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendasMVC.Models;

namespace SistemaVendasMVC.Data
{
    public class SistemaVendasMVCContext : DbContext
    {
        public SistemaVendasMVCContext (DbContextOptions<SistemaVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVendas> RegistroVendas { get; set; }
    }
}
