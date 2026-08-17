using System;
namespace AutoCheck.ConsoleApp
{
    public class ItemVistoria
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public ItemVistoria(string nome, string status)
        {
            Nome = nome;
            Status = status;
        }
    }

}