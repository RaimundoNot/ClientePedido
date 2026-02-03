using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ClientePedido.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public List<ItemPedido> Itens { get; private set; }

        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }

        public void AdcionarPedido(ItemPedido item)
        {
            Itens.Add(item);
        }

        public double CalcularTotal()
        {
            return Itens.Sum(item => item.CalcularTotal()); ;
        }
    }

}