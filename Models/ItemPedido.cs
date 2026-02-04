using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ClientePedido.Models
{
    public class ItemPedido
    {
        public int IdItem { get; set; } // Adicionando a propriedade IdItem
        public string NomeProduto { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public double CalcularTotal()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}