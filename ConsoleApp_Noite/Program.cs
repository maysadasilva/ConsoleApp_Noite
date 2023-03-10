// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using System.Runtime.CompilerServices;

Produto p1 = new Produto(1, 10.90M, "Coca-Cola");
Console.WriteLine(p1.getDescricao()+" "+p1.getId());