using System;   
namespace AutoCheck.ConsoleApp
{
public class Caminhao : Veiculo
{
    public int QuantidadeDeEixos { get; set; }
    public double CapacidadeCargaToneladas { get; set; }
    
    public Caminhao(string marca, string modelo, int quilometragem, int ano, int quantidadeDeEixos, double capacidadeCargaToneladas)
        : base(marca, modelo, quilometragem, ano)
    {
        QuantidadeDeEixos = quantidadeDeEixos;
        CapacidadeCargaToneladas = capacidadeCargaToneladas;
    }
    public override void Preencher()
    {
        base.Preencher(); 
        Console.WriteLine("Quantos eixos: ");
        QuantidadeDeEixos = int.Parse(Console.ReadLine());
        Console.WriteLine("Capacidade de carga (toneladas): ");
        CapacidadeCargaToneladas = double.Parse(Console.ReadLine());
    }
}
}