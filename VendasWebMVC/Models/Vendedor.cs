using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBase { get; set; }
        public DateTime DataNascimento { get; set; }
        //associação, um vendedor possui um departamento
        public Departamento Departamento { get; set; }
        //associação, um vendedor possui várias vendas
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();
        
        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, double salarioBase, DateTime dataNascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataNascimento = dataNascimento;
            Departamento = departamento;
        }

        public void AddVendas(RegistroVendas rv)
        {
            Vendas.Add(rv);
        }
        public void RemoveVendas(RegistroVendas rv)
        {
            Vendas.Remove(rv);
        }
        public Double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= initial && rv.Data <= final).Sum(rv => rv.Valor);
        }

    }
}
