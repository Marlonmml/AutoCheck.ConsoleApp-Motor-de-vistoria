using System;
namespace AutoCheck.ConsoleApp
{
    public class ValidarInt
    {
        public int LerNumero(string mensagemInicial, string mensagemErro)
        {
            int valorInteiro;
            Console.WriteLine(mensagemInicial);
        while (!int.TryParse(Console.ReadLine(), out valorInteiro))
        {
            Console.WriteLine(mensagemErro);
        }
        return valorInteiro;
        }
    }
}
