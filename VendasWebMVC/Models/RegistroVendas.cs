using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double valor, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
