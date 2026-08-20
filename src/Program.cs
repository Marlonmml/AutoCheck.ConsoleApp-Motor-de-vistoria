using System;
namespace AutoCheck.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            MotorVistoria motorVistoria = new MotorVistoria();
            while (true)
            {
                motorVistoria.Executar();
            }
        }
    }
}