using POO_ClientePedido.Models;

Cliente cliente = new Cliente();
cliente.Nome = "Renata";
cliente.Email = "email@email.com";
cliente.Idade = 20;
Console.WriteLine($"Cliente: {cliente.Nome}, Email: {cliente.Email}, Idade: {cliente.Idade}");

Pedido pedido = new Pedido();
ItemPedido item1 = new ItemPedido(10, 2, "Caneta");
ItemPedido item2 = new ItemPedido(5, 5, "Lápis");
ItemPedido item3 = new ItemPedido(20, 1, "Caderno");
pedido.AdcionarPedido(item1);
pedido.AdcionarPedido(item2);
pedido.AdcionarPedido(item3);
Console.WriteLine($"Total do Pedido: R$ {pedido.CalcularTotal()}");




