﻿namespace ConsoleApp_Noite
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string CEP;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }

        public string EnderecoCompleto()
        {
            return Rua+ ", "+Numero+" Bairro:"+ Bairro+" Cidade:" + Cidade + "/" + Estado+" Estado:";
        }

        public string EnderecoCurto()
        {
            return Rua + " " + Numero;

        }
        public Endereco BuscaPorCep(string cep)//busca o objeto
        {
            return new Endereco("", "", "", cep, "", ""); 
        }

        public string EstadoPorCidade(string estado)
        {
            if(estado== "sp")
            {
                return "Taquaritinga";
            }
            return Cidade;
        }

        public void InserirNoBanco(Endereco endereco)
        {
            //db.ENDERECO.ADD(endereco)
            //db.savechanges();
        }




        private void SetRua(string rua)
        {
            Rua = rua;
        }

        public void SetNumero(string numero)
        {
            Numero = numero;
        }

        private void SetBairro(string bairro)
        {
            Bairro = bairro;
        }

        private void SetCep(string cep)
        {
            CEP = cep;
        }

        private void SetCidade(string cidade)
        {
            Cidade = cidade;
        }
        private void SetEstado(string estado)
        {
            Estado = estado;
        }

        public string getRua()
        {
            return Rua;
        }
        public string getNumero()
        {
            return Numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public string getCEP()
        {
            return CEP;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public string getEstado()
        {
            return Estado;
        }


    }
}
