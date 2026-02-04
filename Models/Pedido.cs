using System;
using System.Collections.Generic;
using System.Linq;

namespace POO_ClientePedido.Models
{
    public class Pedido
    {
        private static int _proximoId = 1; // Gerador de IDs

        public int IdPedido { get; private set; }
        public List<ItemPedido> Itens { get; private set; }

        public Pedido()
        {
            IdPedido = _proximoId++; // Cada novo pedido recebe um ID único
            Itens = new List<ItemPedido>();
        }

        public void AdicionarPedido(ItemPedido item)
        {
            // Gera um ID único para o item se ele não tiver
            if (item.IdItem == 0)
            {
                item.IdItem = Itens.Count + 1;
            }
            Itens.Add(item);
        }

        public void RemoverPedido(ItemPedido item)
        {
            // Busca o item pelo IdItem, não pelo objeto inteiro
            var itemParaRemover = Itens.FirstOrDefault(i => i.IdItem == item.IdItem);
            if (itemParaRemover != null)
            {
                Itens.Remove(itemParaRemover); // Agora SIM remove
            }
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
            }
            else
            {
                var itensEncontrados = Itens.Where(item => item.NomeProduto.Contains(nomeProduto));
                if (itensEncontrados.Any())
                {
                    foreach (var item in itensEncontrados)
                    {
                        Console.WriteLine($"Produto: {item.NomeProduto}, Preço Unitário: {item.PrecoUnitario}, Quantidade: {item.Quantidade}, Total: {item.CalcularTotal()}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum item encontrado com o nome fornecido.");
                }
            }
        }

        public double CalcularTotal()
        {
            return Itens.Sum(item => item.CalcularTotal());
        }
    }
}