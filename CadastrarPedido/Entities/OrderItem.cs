using System;
using System.Collections.Generic;
using System.Text;

namespace CadastrarPedido.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {            
            return Quantity * Price;
        }
    }
}
