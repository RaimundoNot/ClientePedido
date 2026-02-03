using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ClientePedido.Models
{
    public class ItemPedido : Pedido
    {
        public int PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public string NomeProduto { get; set; }

        public ItemPedido(int precoUnitario, int quantidade, string nomeProduto)
        {
            this.PrecoUnitario = precoUnitario;
            this.Quantidade = quantidade;
            this.NomeProduto = nomeProduto;
        }

        public double CalcularTotal()
        {
            return Quantidade * PrecoUnitario;
        }
    }
}