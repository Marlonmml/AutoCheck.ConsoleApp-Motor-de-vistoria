using System;
namespace AutoCheck.ConsoleApp
{   
    public class MotorVistoria
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        public void Executar()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("|    AUTOCHECK .NET - MOTOR DE VISTORIA   |");
            Console.WriteLine("===========================================");
            Console.WriteLine("|         DIGITE A OPÇÃO DESEJADA         |\n");
            Console.WriteLine("1 - Realizar Nova Vistoria ");
            Console.WriteLine("2 - Exibir Relatório das Vistorias ");
            Console.WriteLine("3 - Sair \n");
            Console.WriteLine(" Escolha uma opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Veiculo novoVeiculo = null;
                    Console.WriteLine("===========================================");
                    Console.WriteLine("|           CADASTRO DE VEÍCULO           |");
                    Console.WriteLine("           Qual tipo de veículo? \n");
                    Console.WriteLine("1 - Carro");
                    Console.WriteLine("2 - Moto");
                    Console.WriteLine("3 - Caminhão\n");
                    Console.Write(" Escolha uma opção: ");
                    string tipoVeiculo = Console.ReadLine();
                    if (tipoVeiculo == "1")
                    {
                        novoVeiculo = new Carro("", "", 0, 0, 0);
                        Console.WriteLine("\nInforme os dados do Carro");
                    }
                    else if (tipoVeiculo == "2")
                    {
                        novoVeiculo = new Moto("", "", 0, 0, 0);
                        Console.WriteLine("\nInforme os dados da Moto");
                    }
                    else if (tipoVeiculo == "3")
                    {
                        novoVeiculo = new Caminhao("", "", 0, 0, 0, 0);
                        Console.WriteLine("\nInforme os dados do Caminhão");
                    }
                    else
                    {
                        Console.WriteLine("\n    Por favor, digite uma opção válida!    ");
                        Console.ReadKey();
                        return;
                    }
                    novoVeiculo.Preencher();
                    Console.WriteLine("===========================================");
                    Console.WriteLine("|      VEÍCULO CADASTRADO COM SUCESSO     |");
                    Console.WriteLine($"  Marca: {novoVeiculo.Marca}");
                    Console.WriteLine($"  Modelo: {novoVeiculo.Modelo}");
                    Console.WriteLine($"  Ano: {novoVeiculo.Ano}");
                    Console.WriteLine($"  Quilometragem: {novoVeiculo.Quilometragem}km");
                    if (novoVeiculo is Carro carroCadastrado)
                    {
                        Console.WriteLine($"  Portas: {carroCadastrado.QuantidadeDePortas}");
                    }
                    else if (novoVeiculo is Moto motoCadastrada)
                    {
                        Console.WriteLine($"  Cilindradas: {motoCadastrada.Cilindradas}cc");
                    }
                    else if (novoVeiculo is Caminhao caminhaoCadastrado)
                    {
                        Console.WriteLine($"  Eixos: {caminhaoCadastrado.QuantidadeDeEixos}");
                        Console.WriteLine($"  Capacidade de carga: {caminhaoCadastrado.CapacidadeCargaToneladas}t");
                    }
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("|          CHECKLIST OBRIGATÓRIO          |");
                    Console.WriteLine("       Descreva a condição dos itens       ");
                    novoVeiculo.RealizarVistoria();
                    veiculos.Add(novoVeiculo);
                    Console.WriteLine("\n|     Veículo e vistoria cadastrados!     |");
                    break;
                case "2":
                    ExibirRelatorioVistorias();
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("===========================================");
                    break;
                case "3":
                    Console.WriteLine("\n| Obrigado por utilizar o AutoCheck .NET! |");
                    Console.WriteLine("===========================================\n\n");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n    Por favor, digite uma opção válida!    ");
                    Console.ReadKey();
                    return;
            }
        }
        private void ExibirRelatorioVistorias()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("|        RELATÓRIO DE VISTORIAS           |");
            Console.WriteLine("===========================================");
            if (veiculos.Count == 0)
            {
                Console.WriteLine("|    NENHUMA VISTORIA REALIZADA AINDA.    |");
                Console.WriteLine("|  Pressione ENTER para retornar ao menu  |");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"|         Código da vistoria: {i+1}           |");
                veiculos[i].ExibirVistoriaRealizada();
                var avaliador = new AvaliadorVistoria();
                avaliador.Calcular(veiculos[i].VistoriaRealizada);
                avaliador.Exibir();
            }
        } 
    }
}