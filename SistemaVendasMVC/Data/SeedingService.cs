using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendasMVC.Models;
using SistemaVendasMVC.Models.Enums;

namespace SistemaVendasMVC.Data
{
    public class SeedingService
    {
        private SistemaVendasMVCContext _context;

        public SeedingService(SistemaVendasMVCContext context) 
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendas.Any()) 
            {
                return; // O banco de dados ja foi populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Joao Neves", "joaone@gmail.com", new DateTime(1998, 4, 3), 1000.0, d1);
            Vendedor v2 = new Vendedor(2, "Maria Rosa", "mariarosa@gmail.com", new DateTime(1975, 12, 15), 3990.0, d3);
            Vendedor v3 = new Vendedor(3, "Alexandre Silva", "alexsilva@gmail.com", new DateTime(1985, 10, 24), 2000.0, d2);
            Vendedor v4 = new Vendedor(4, "Fernanda Moura", "ffernandam@gmail.com", new DateTime(1995, 1, 27), 3500.0, d3);
            Vendedor v5 = new Vendedor(5, "Joana Dark", "joanadark@gmail.com", new DateTime(1985, 12, 24), 4000.0, d4);
            Vendedor v6 = new Vendedor(6, "Jesse Pinkman", "jessepm@gmail.com", new DateTime(1989, 8, 10), 2500.0, d2);

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2021, 01, 20), 12000.0, StatusVenda.Faturado, v1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2021, 01, 21), 9000.0, StatusVenda.Pendente, v2);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2021, 01, 21), 5000.0, StatusVenda.Cancelado, v3);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2021, 01, 22), 7000.0, StatusVenda.Faturado, v4);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2021, 01, 23), 2000.0, StatusVenda.Cancelado, v5);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2021, 01, 24), 4000.0, StatusVenda.Faturado, v6);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2021, 01, 25), 10000.0, StatusVenda.Faturado, v1);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2021, 01, 26), 11000.0, StatusVenda.Faturado, v2);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2021, 01, 27), 1000.0, StatusVenda.Faturado, v3);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2021, 01, 28), 9000.0, StatusVenda.Faturado, v4);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2021, 01, 29), 1500.0, StatusVenda.Faturado, v5);
            RegistroVendas r12 = new RegistroVendas(12, new DateTime(2021, 01, 29), 2700.0, StatusVenda.Faturado, v6);
            RegistroVendas r13 = new RegistroVendas(13, new DateTime(2021, 01, 30), 900.0, StatusVenda.Faturado, v1);
            RegistroVendas r14 = new RegistroVendas(14, new DateTime(2021, 01, 30), 700.0, StatusVenda.Faturado, v1);
            RegistroVendas r15 = new RegistroVendas(15, new DateTime(2021, 02, 1), 500.0, StatusVenda.Faturado, v1);
            RegistroVendas r16 = new RegistroVendas(16, new DateTime(2021, 02, 2), 1000.0, StatusVenda.Faturado, v2);
            RegistroVendas r17 = new RegistroVendas(17, new DateTime(2021, 02, 2), 600.0, StatusVenda.Cancelado, v3);
            RegistroVendas r18 = new RegistroVendas(18, new DateTime(2021, 02, 3), 1000.0, StatusVenda.Pendente, v4);
            RegistroVendas r19 = new RegistroVendas(19, new DateTime(2021, 02, 5), 100.0, StatusVenda.Faturado, v4);
            RegistroVendas r20 = new RegistroVendas(20, new DateTime(2021, 02, 6), 50.0, StatusVenda.Faturado, v5);
            RegistroVendas r21 = new RegistroVendas(21, new DateTime(2021, 02, 7), 5000.0, StatusVenda.Pendente, v6);
            RegistroVendas r22 = new RegistroVendas(22, new DateTime(2021, 02, 7), 5000.0, StatusVenda.Pendente, v1);
            RegistroVendas r23 = new RegistroVendas(23, new DateTime(2021, 02, 7), 4000.0, StatusVenda.Pendente, v1) ;
            RegistroVendas r24 = new RegistroVendas(24, new DateTime(2021, 02, 8), 500.0, StatusVenda.Cancelado, v1);
            RegistroVendas r25 = new RegistroVendas(25, new DateTime(2021, 02, 10), 100.0, StatusVenda.Cancelado, v2);
            RegistroVendas r26 = new RegistroVendas(26, new DateTime(2021, 02, 10), 2500.0, StatusVenda.Faturado, v3);
            RegistroVendas r27 = new RegistroVendas(27, new DateTime(2021, 02, 10), 10000.0, StatusVenda.Faturado, v5);
            RegistroVendas r28 = new RegistroVendas(28, new DateTime(2021, 02, 10), 6500.0, StatusVenda.Faturado, v6);
            RegistroVendas r29 = new RegistroVendas(29, new DateTime(2021, 02, 11), 1300.0, StatusVenda.Pendente, v6);
            RegistroVendas r30 = new RegistroVendas(30, new DateTime(2021, 02, 11), 1470.0, StatusVenda.Faturado, v5);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.RegistroVendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r18, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
