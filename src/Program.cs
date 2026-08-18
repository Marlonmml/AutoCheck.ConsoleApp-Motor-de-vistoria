using System;   
namespace AutoCheck.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                MotorVistoria motorVistoria = new MotorVistoria();
                motorVistoria.Executar();
            }
        }
    }
}