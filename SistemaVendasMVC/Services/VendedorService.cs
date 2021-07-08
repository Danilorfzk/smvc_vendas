using SistemaVendasMVC.Data;
using SistemaVendasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendasMVC.Services
{
    public class VendedorService
    {
        private readonly SistemaVendasMVCContext _context;

        public VendedorService(SistemaVendasMVCContext context)
        {
            _context = context;
        }
        //Metodo que vai retornar uma lista de vendedores
        public List<Vendedor> FindAll ()
        {
            return _context.Vendedor.ToList();
        }
    }
}
