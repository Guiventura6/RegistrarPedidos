using CadastrarPedido.Entities;
using System;

namespace CadastrarPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Console.WriteLine($"{client.Name}, {client.Email}, {client.BirthDate}");

            Console.WriteLine();
            Console.Write("Enter order data:");
        }
    }
}
