using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;

namespace VendasWebMVC.Data
{
    public class SeendingService
    {
        private VendasWebMVCContext _context;

        public SeendingService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendas.Any())
            {
                return; //banco de dados já foi populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletrônicos");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "João", "joao@gmail.com", 1000.0,new DateTime(1998, 6, 01), d1);
            Vendedor v2 = new Vendedor(2, "Ana", "ana@gmail.com", 1000.0, new DateTime(1945, 5, 21), d1);
            Vendedor v3 = new Vendedor(3, "Cleber", "cleber@gmail.com", 1000.0, new DateTime(2000, 2, 11), d3);
            Vendedor v4 = new Vendedor(4, "Maria", "maria@gmail.com", 1000.0, new DateTime(2001, 4, 14), d4);
            Vendedor v5 = new Vendedor(5, "Lucia", "lucia@gmail.com", 1000.0, new DateTime(1989, 3, 30), d2);
            Vendedor v6 = new Vendedor(6, "Aline", "aline@gmail.com", 1000.0, new DateTime(1990, 3, 09), d1);

            RegistroVendas r1 = new RegistroVendas(1, DateTime.Now, 11000.0, Models.Enums.VendaStatus.Pendente, v1);
            RegistroVendas r2 = new RegistroVendas(2, DateTime.Now, 13400.0, Models.Enums.VendaStatus.Pendente, v1);
            RegistroVendas r3 = new RegistroVendas(3, DateTime.Now, 1000.0, Models.Enums.VendaStatus.Pendente, v3);
            RegistroVendas r4 = new RegistroVendas(4, DateTime.Now, 11000.0, Models.Enums.VendaStatus.Pendente, v1);
            RegistroVendas r5 = new RegistroVendas(5, DateTime.Now, 14300.0, Models.Enums.VendaStatus.Pendente, v1);
            RegistroVendas r6 = new RegistroVendas(6, DateTime.Now, 34340.0, Models.Enums.VendaStatus.Pendente, v1);
            RegistroVendas r7 = new RegistroVendas(7, DateTime.Now, 1230.0, Models.Enums.VendaStatus.Pendente, v4);
            RegistroVendas r8 = new RegistroVendas(8, DateTime.Now, 110.0, Models.Enums.VendaStatus.Pendente, v5);
            RegistroVendas r9 = new RegistroVendas(9, DateTime.Now, 124200.0, Models.Enums.VendaStatus.Pendente, v6);
            RegistroVendas r10 = new RegistroVendas(10, DateTime.Now, 1135.0, Models.Enums.VendaStatus.Pendente, v6);
            RegistroVendas r11 = new RegistroVendas(11, DateTime.Now, 234000.0, Models.Enums.VendaStatus.Pendente, v2);
            RegistroVendas r12 = new RegistroVendas(12, DateTime.Now, 110400.0, Models.Enums.VendaStatus.Pendente, v4);
            RegistroVendas r13 = new RegistroVendas(13, DateTime.Now, 1340.0, Models.Enums.VendaStatus.Pendente, v1);
            RegistroVendas r14 = new RegistroVendas(14, DateTime.Now, 5000.0, Models.Enums.VendaStatus.Pendente, v4);
            RegistroVendas r15 = new RegistroVendas(15, DateTime.Now, 6000.0, Models.Enums.VendaStatus.Pendente, v5);
            RegistroVendas r16 = new RegistroVendas(16, DateTime.Now, 14000.0, Models.Enums.VendaStatus.Pendente, v6);
            RegistroVendas r17 = new RegistroVendas(17, DateTime.Now, 14000.0, Models.Enums.VendaStatus.Pendente, v3);
            RegistroVendas r18 = new RegistroVendas(18, DateTime.Now, 3000.0, Models.Enums.VendaStatus.Pendente, v3);
            RegistroVendas r19 = new RegistroVendas(19, DateTime.Now, 1000.0, Models.Enums.VendaStatus.Pendente, v5);
            RegistroVendas r20 = new RegistroVendas(20, DateTime.Now, 1000.0, Models.Enums.VendaStatus.Pendente, v5);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
            _context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19,r20);

            _context.SaveChanges();
        }


    }
}
