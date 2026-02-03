using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace POO_ClientePedido.Models
{
    public class Pedido
    {
        public int IdPedido { get; private set; }
        public List<ItemPedido> Itens { get; private set; }

        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }

        public void AdcionarPedido(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoverPedido(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public void ListarPedidos()
        {
            foreach (var item in Itens)
            {
                Console.WriteLine($"Produto: {item.NomeProduto}, Preço Unitário: {item.PrecoUnitario}, Quantidade: {item.Quantidade}, Total: {item.CalcularTotal()}");
            }
        }

        public void LimparPedidos()
        {
            Itens.Clear();
        }

        public void AtualizarPedido(int index, ItemPedido novoItem)
        {
            if (index >= 0 && index < Itens.Count)
            {
                Itens[index] = novoItem;
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            } 
        }

        public void BuscarPedido(string nomeProduto)
        {
            if (Itens.Count == 0)
            {
                Console.WriteLine("Nenhum item no pedido.");
                return;
            } else {
                var itensEncontrados = Itens.Where(item => item.NomeProduto.Contains(nomeProduto));
                if (itensEncontrados.Any())
                {
                    foreach (var item in itensEncontrados)
                    {
                        Console.WriteLine($"Produto: {item.NomeProduto}, Preço Unitário: {item.PrecoUnitario}, Quantidade: {item.Quantidade}, Total: {item.CalcularTotal()}");
                    }
                } else
                {
                    Console.WriteLine("Nenhum item encontrado com o nome fornecido.");
                }
            }
        }

        public double CalcularTotal()
        {
            return Itens.Sum(item => item.CalcularTotal()); ;
        }
    }

}