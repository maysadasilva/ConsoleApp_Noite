using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;

        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
            if(nome !="")
            {
                Nome = nome;
            }
        }

        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

    }
}
