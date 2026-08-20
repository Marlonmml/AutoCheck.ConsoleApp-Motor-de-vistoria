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
            this.QuantidadeDeEixos = quantidadeDeEixos;
            this.CapacidadeCargaToneladas = capacidadeCargaToneladas;
        }
        public override void Preencher()
        {
            base.Preencher();
            QuantidadeDeEixos = new ValidarInt().LerNumero("Número de eixos: ", "Apenas números, Digite a quantidade de eixos novamente: ");
            Console.WriteLine("Capacidade de carga (toneladas): ");
            CapacidadeCargaToneladas = double.Parse(Console.ReadLine());
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            var checkList = base.ObterChecklistObrigatorio();
            checkList.Add("Tacógrafo, Refletores, Sinalização");
            checkList.Add("Carroceria, Engate, Eixo semi-eixo");
            return checkList;
        }
    }
}