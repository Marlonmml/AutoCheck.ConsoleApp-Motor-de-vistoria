using System;
namespace AutoCheck.ConsoleApp
{
public class Carro : Veiculo
{
    public int QuantidadeDePortas { get; set; }
    public Carro(string marca, string modelo, int quilometragem, int ano, int quantidadeDePortas)
        : base(marca, modelo, quilometragem, ano)
    {
        QuantidadeDePortas = quantidadeDePortas;
    }
    public override void Preencher()
    {
        base.Preencher(); 
        Console.WriteLine("Quantas portas: ");
        QuantidadeDePortas = int.Parse(Console.ReadLine());
    }
  
}
}