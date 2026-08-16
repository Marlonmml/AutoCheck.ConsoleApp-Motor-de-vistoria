using System;
namespace AutoCheck.ConsoleApp
{
    public abstract class Veiculo
    {
        protected Veiculo()
        {
        }
        protected Veiculo(string marca, string modelo, int quilometragem, int ano)
        { 
            Marca = marca;
            Modelo = modelo;
            Quilometragem = quilometragem;
            Ano = ano;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Quilometragem { get; set; }
        public int Ano { get; set; }
        public virtual void Preencher()
        {
            Console.WriteLine("Digite a marca: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo: "); 
            Modelo = Console.ReadLine();
            Console.WriteLine("Digite a quilometragem: ");
            Quilometragem = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ano:");
            Ano = int.Parse(Console.ReadLine());
        }

        public virtual void ObterChecklistObrigatorio()
        {
            Console.WriteLine("Checklist obrigatório para o veículo:");
            Console.WriteLine("1. Verificar pneus");
            Console.WriteLine("2. Verificar freios");
            Console.WriteLine("3. Verificar luzes");
            Console.WriteLine("4. Verificar óleo");
        }
        
    }
}