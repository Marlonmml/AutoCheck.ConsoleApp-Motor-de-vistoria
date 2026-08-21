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
            this.Marca = marca;
            this.Modelo = modelo;
            this.Quilometragem = quilometragem;
            this.Ano = ano;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Quilometragem { get; set; }
        public int Ano { get; set; }
        public List<ItemVistoria> VistoriaRealizada { get; set; } = new List<ItemVistoria>();
        public virtual void Preencher()
        {
            Console.WriteLine("Digite a marca: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo: ");
            Modelo = Console.ReadLine();
            Quilometragem = new ValidarInt().LerNumero("Digite a quilometragem: ", "Apenas números, Digite quilometragem novamente: ");
            Ano = new ValidarInt().LerNumero("Digite o ano: ", "Apenas números, Digite ano novamente: ");
        }
        public void AdicionarItemVistoriado(string nome, string status)
        {
            var item = new ItemVistoria(nome, status);
            VistoriaRealizada.Add(item);
        }

        public virtual List<string> ObterChecklistObrigatorio()
        {
            var baseCheckList = new List<string>();
            baseCheckList.Add("Lataria, Barulhos, Vazamentos");
            baseCheckList.Add("Motor, Elétrica, Suspensão");
            baseCheckList.Add("Nº Chassi, Segurança, Documentos");
            return baseCheckList;
        }
        public void RealizarVistoria()
        {
            foreach (var item in ObterChecklistObrigatorio())
            {
                
                Console.WriteLine("\n>> Use apenas 'Bom', 'Regular' ou 'Ruim': ");
                Console.WriteLine($"Itens: {item}");
                string status = LerStatus();
                AdicionarItemVistoriado(item, status);
            }
        }
        private string LerStatus(string mensagem = "")
        {
            string status;
            do
            {
                Console.WriteLine(mensagem);
                status = Console.ReadLine();
            }
            while (status != "Bom" && status != "Regular" && status != "Ruim");
            return status;
        }
        public void ExibirVistoriaRealizada()
        {
            if (VistoriaRealizada.Count == 0)
            {
                return;
            }
            Console.WriteLine($" Veículo {Marca} {Modelo} Ano {Ano}");
            foreach (var item in VistoriaRealizada)
            {
                Console.WriteLine($"- {item.Nome}: {item.Status}");
            }
        }
    }
}
