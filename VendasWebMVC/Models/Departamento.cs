using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        //associação, um departamento possui vários vendedores
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        //construtor sem argumentos
        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalVendas(initial, final));
        }
    }
}
