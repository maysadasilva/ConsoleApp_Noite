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
        private Endereco Endereco;

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
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
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
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
        public Endereco getEndereco()
        {
            return Endereco;
        }

    }
}
