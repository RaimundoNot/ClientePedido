using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ClientePedido.Models
{

    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public Cliente(string nome, string email, int idade)
        {
            this.Nome = nome;
            this.Email = email;
            this.Idade = idade;
        }

        public Cliente()
        { }

    }
}