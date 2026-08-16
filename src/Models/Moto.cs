using System;
namespace AutoCheck.ConsoleApp
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public Moto(string marca, string modelo, int quilometragem,  int ano, int cilindradas)
            : base(marca, modelo, quilometragem, ano)
        {
            Cilindradas = cilindradas;
        }
        public override void Preencher()
        {
            base.Preencher(); 
            Console.WriteLine("Qual a cilindrada: ");
            Cilindradas = int.Parse(Console.ReadLine());
            
        }
        
    }
}