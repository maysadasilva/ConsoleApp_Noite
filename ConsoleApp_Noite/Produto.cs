using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Produto
    {
        private int Id;
        private decimal Valor;
        public string Descricao;

        public Produto(int id,decimal valor, string descricao )
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;


        }
    }
}
