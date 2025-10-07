using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoEstacionamento.Models
{
    internal class Cliente
    {
        public Cliente(string nome)
        {
            Nome = nome;
        }
     public string id { get; set; } 

     public string Nome { get; private set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }




    }
}
