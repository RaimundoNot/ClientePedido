
# POO-ClientePedido

## Descrição
Sistema simples de gerenciamento de clientes e pedidos desenvolvido em C#, utilizando princípios de Programação Orientada a Objetos (POO).

## Classes

### Cliente
Representa um cliente do sistema com os seguintes atributos:
- **Nome**: Nome do cliente
- **Email**: Endereço de email
- **Idade**: Idade do cliente

Possui um construtor parametrizado e um construtor padrão.

### Pedido
Gerencia uma lista de itens de pedido com as seguintes funcionalidades:
- **IdPedido**: Identificador do pedido
- **Itens**: Lista de itens do pedido
- **AdcionarPedido()**: Adiciona um item à lista
- **RemoverPedido()**: Remove um item da lista
- **AtualizarPedido()**: Atualiza um item existente na lista
- **LimparPedidos()**: Limpa todos os itens do pedido
- **BuscarPedido()**: Busca um item na lista pelo nome do produto
- **CalcularTotal()**: Calcula o valor total do pedido somando todos os itens

### ItemPedido
Representa um item específico dentro de um pedido:
- **PrecoUnitario**: Preço de uma unidade
- **Quantidade**: Quantidade de produtos
- **NomeProduto**: Nome do produto
- **CalcularTotal()**: Calcula o subtotal (quantidade × preço unitário)

## Como Usar no Program.cs

```csharp
// Criar e configurar cliente
Cliente cliente = new Cliente();
cliente.Nome = "Renata";
cliente.Email = "email@email.com";
cliente.Idade = 20;

// Criar pedido e adicionar itens
Pedido pedido = new Pedido();
ItemPedido item1 = new ItemPedido(10, 2, "Caneta");
ItemPedido item2 = new ItemPedido(5, 5, "Lápis");
pedido.AdcionarPedido(item1);
pedido.AdcionarPedido(item2);

// Remover um item
pedido.RemoverPedido(item1);

// Atualizar um item
ItemPedido novoItem = new ItemPedido(6, 3, "Lápis");
pedido.AtualizarPedido(0, novoItem);

// Limpar todos os itens
pedido.LimparPedidos();

// Listar itens
pedido.ListarPedidos();

// Buscar um item
pedido.BuscarPedido("Lápis");

// Exibir resultados
Console.WriteLine($"Total: R$ {pedido.CalcularTotal()}");
```
