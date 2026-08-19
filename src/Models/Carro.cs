using System;
namespace AutoCheck.ConsoleApp
{
    public class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }
        public Carro(string marca, string modelo, int quilometragem, int ano, int quantidadeDePortas)
            : base(marca, modelo, quilometragem, ano)
        {
            this.QuantidadeDePortas = quantidadeDePortas;
        }
        public override void Preencher()
        {
            base.Preencher();
            QuantidadeDePortas = new ValidarInt().LerNumero("Número de portas: ", "Apenas números, Digite quantidade de portas novamente: ");
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Interna, Painel, Estofamento");
            checklist.Add("Vidros, Estepe, Macaco Hidráulico");
            return checklist;
        }
    }
}