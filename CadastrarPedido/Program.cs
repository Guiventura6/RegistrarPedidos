using System;
using CadastrarPedido.Entities;
using CadastrarPedido.Entities.Enums;
using System.Globalization;


namespace CadastrarPedido
{
    class Program
    {

        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            //Instanciando o objeto Cliente
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);           
            
            //Incluindo os items da Ordem 
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status);
            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.Items.Add(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            
        }
    }
}
