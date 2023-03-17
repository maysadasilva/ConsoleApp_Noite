using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Herenca
{

    
        public class Carro: Veiculo
        {
            public bool cintoSeguranca;
            public bool arCondicionado;
            public string marcaRadio;
            public string fabricante;

            public string ExibirMarca()//uma nova ação
            {
                 return "O fabricante do veiculo: " + fabricante;
            }

        }
    
}
