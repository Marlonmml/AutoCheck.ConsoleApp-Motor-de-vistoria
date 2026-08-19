using System;
namespace AutoCheck.ConsoleApp
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public Moto(string marca, string modelo, int quilometragem,  int ano, int cilindradas)
            : base(marca, modelo, quilometragem, ano)
        {
            this.Cilindradas = cilindradas;
        }
        public override void Preencher()
        {
            base.Preencher(); 
            Cilindradas = new ValidarInt().LerNumero("Quantas cilindradas: ", "Apenas números, Digite cilindradas novamente: ");
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Relação, Transmissão, Escapamento");
            checklist.Add("Folga em rodas, caixa direção");
            return checklist;
        }
    }
}