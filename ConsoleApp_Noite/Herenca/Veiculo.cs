﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Herenca
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            if(temMotor==true)
            {
                return "Com motor, Assentos:" + "Número de assentos: " + numeroAssentos + " Número de Portas: " + numeroPortas;
            }
            else
            {
                return numeroAssentos + " " + numeroPortas;
            }
        }

    }
}
