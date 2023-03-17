// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using ConsoleApp_Noite.Herenca;
using System.Runtime.CompilerServices;

Produto p1 = new Produto(1, 10.90M, "Coca-Cola");
Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Coca-Cola 2 litros");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco endereco = new Endereco("Rua Mário Donega", "1222", "Campo", "54848787", "Guariba", "SP");

Cliente c1 = new Cliente(1, "Gabriel", "9999998966", endereco);//construtor
Cliente c2 = new Cliente(2, "Mário", "987655636", endereco);
Cliente c3 = new Cliente(3, "Julia", "8921646999", endereco);
Cliente c4 = new Cliente(4, "Jóse", "556599985998", endereco);
Cliente c5 = new Cliente(5, "Maria", "3669869999", endereco);

Console.WriteLine( c2.getEndereco().getRua() + " "+c2.getEndereco().getNumero());
c2.getEndereco().SetNumero("135");
//Console.WriteLine(c2.getEndereco().EnderecoCompleto);

c2.getEndereco().EnderecoCompleto();

Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;
gol.cintoSeguranca = true;
gol.arCondicionado = false;
gol.fabricante = "VW";

Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Palio.fabricante = "Fiat";
Uno.fabricante = "Fiat";

Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;