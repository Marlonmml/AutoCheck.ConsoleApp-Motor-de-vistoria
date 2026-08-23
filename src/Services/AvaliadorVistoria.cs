using System;
namespace AutoCheck.ConsoleApp
{
    public class AvaliadorVistoria
    {
        private const int PontosBom = 10;
        private const int PontosRegular = 5;
        private const int PontosRuim = 0;
        public int PontuacaoObtida { get; set; }
        public int PontuacaoMaxima { get; set; }
        public double Percentual { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public string Apontamentos { get; set; }
        public bool temApontamentos { get; set; }
        public void Calcular(List<ItemVistoria> itens)
        {
            if (itens == null || itens.Count == 0)
            {
                PontuacaoObtida = 0;
                PontuacaoMaxima = 0;
                Percentual = 0;
                return;
            }
            PontuacaoMaxima = itens.Count * PontosBom;
            PontuacaoObtida = 0;

            foreach (var item in itens)
            {
                PontuacaoObtida += ObterPontuacao(item.Status);
            }
            Percentual = (double)PontuacaoObtida / PontuacaoMaxima * 100;
            Apontamentos = ApontamentosItens(itens);
            DefinirClassificacao();
        }
        private int ObterPontuacao(string status)
        {
            if (status == "Bom")
            {
                return PontosBom;
            }
            else if (status == "Regular")
            {
                return PontosRegular;
            }
            else if (status == "Ruim")
            {
                return PontosRuim;
            }
            else
            {
                return 0;
            }
        }
        private void DefinirClassificacao()
        {
            if (Percentual >= 90)
            {
                temApontamentos = false; 
                Classificacao = " Aprovado com Excelência.";
                Descricao = "  Liberado para compra/revenda imediata.\n";
            }
            else if (Percentual >= 60)
            {                    
                temApontamentos = true; 
                Classificacao = " Aprovado com Apontamentos.";
                Descricao =     "  Exige desconto para reparos da oficina.\n";
            }
            else
            { 
                temApontamentos = true; 
                Classificacao = " Reprovado na Vistoria.";
                Descricao =     "  Veículo recusado pela concessionária.\n";
            }
        }
        private string ApontamentosItens(List<ItemVistoria> itens)
        {
            string apontamentos = "";
            foreach (var item in itens)
            {
                if (item.Status == "Regular")
                {
                    apontamentos += $"\n{item.Nome} ({item.Status})\nExige revisão preventiva.\n";
                    
                }
                else if (item.Status == "Ruim")
                {
                    apontamentos += $"\n{item.Nome} ({item.Status})\nExige reparo/troca obrigatória.\n";
                    
                }
            }
            return apontamentos;
        }
        public virtual void Exibir()
        {          
            Console.WriteLine($"\nPontuação: {PontuacaoObtida}/{PontuacaoMaxima} ({Percentual:F1}%)");
            Console.WriteLine($"Resultado: {Classificacao}");
            Console.WriteLine(Descricao);
            if (Apontamentos != "")
            {
                Console.WriteLine("Apontamentos:");
                Console.WriteLine(Apontamentos);
            }
        }
    }
}