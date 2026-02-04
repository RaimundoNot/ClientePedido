# POO-ClientePedido - API REST com Swagger

## Descrição

Transformação de um sistema de gerenciamento de clientes e pedidos em uma **API REST moderna** desenvolvida em C# com ASP.NET Core. O projeto implementa princípios de Programação Orientada a Objetos (POO) e utiliza **Swagger/OpenAPI** para documentação e teste interativo da API.

## Principais Alterações

### De Aplicação Console para API REST

O programa foi transformado de uma aplicação console tradicional para uma **API REST completa**, permitindo:

- Acesso via requisições HTTP (GET, POST, PUT, DELETE)
- Integração com interfaces web e mobile
- Documentação automática via Swagger
- Testes interativos direto no navegador

## Modelos de Dados

### Cliente

Representa um cliente do sistema:

- **Nome**: Nome do cliente
- **Email**: Endereço de email
- **Idade**: Idade do cliente

### Pedido

Gerencia uma lista de itens de pedido com as seguintes funcionalidades:

- **IdPedido**: Identificador do pedido
- **Itens**: Lista de itens do pedido
- **AdicionarPedido()**: Adiciona um item à lista
- **RemoverPedido()**: Remove um item da lista
- **AtualizarPedido()**: Atualiza um item existente
- **LimparPedidos()**: Limpa todos os itens do pedido
- **CalcularTotal()**: Calcula o valor total do pedido

### ItemPedido

Representa um item específico dentro de um pedido:

- **PrecoUnitario**: Preço de uma unidade
- **Quantidade**: Quantidade de produtos
- **NomeProduto**: Nome do produto
- **CalcularTotal()**: Calcula o subtotal (quantidade × preço unitário)

## Endpoints da API (PedidoController)

A classe `PedidoController` expõe os seguintes endpoints REST:

### POST `/api/pedido/adicionar`

Adiciona um novo item ao pedido.

```json
Body: {
  "nomeProduto": "Caneta",
  "precoUnitario": 10.0,
  "quantidade": 2
}
Response: "Item adicionado ao pedido."
```

### DELETE `/api/pedido/remover`

Remove um item do pedido.

```json
Body: {
  "nomeProduto": "Caneta",
  "precoUnitario": 10.0,
  "quantidade": 2
}
Response: "Item removido do pedido."
```

### GET `/api/pedido/listar`

Lista todos os itens do pedido atual.

```json
Response: [
  {
    "nomeProduto": "Caneta",
    "precoUnitario": 10.0,
    "quantidade": 2
  }
]
```

### DELETE `/api/pedido/limpar`

Remove todos os itens do pedido.

```
Response: "Pedido limpo."
```

### PUT `/api/pedido/atualizar/{index}`

Atualiza um item específico do pedido.

```
Parameter: index (inteiro)
Body: ItemPedido
Response: "Pedido atualizado."
```

### GET `/api/pedido/buscar`

Busca itens por nome de produto.

```
Query Parameter: nomeProduto (string)
Response: Array de ItemPedido filtrado
```

### GET `/api/pedido/total`

Calcula o valor total do pedido.

```json
Response: {
  "total": 20.0
}
```

## Como Usar

### 1. Executar a Aplicação

```bash
dotnet watch run
```

### 2. Acessar o Swagger

Abra seu navegador e vá para:

```
https://localhost:5000/swagger
```

### 3. Testar os Endpoints

Utilize a interface do Swagger para:

- Visualizar documentação completa de cada endpoint
- Testar requisições diretamente no navegador
- Ver exemplos de request e response
- Enviar dados em tempo real

### 4. Exemplo com cURL

```bash
# Adicionar item
curl -X POST "https://localhost:5000/api/pedido/adicionar" \
  -H "Content-Type: application/json" \
  -d '{"nomeProduto":"Caneta","precoUnitario":10,"quantidade":2}'

# Listar pedidos
curl -X GET "https://localhost:5000/api/pedido/listar"

# Calcular total
curl -X GET "https://localhost:5000/api/pedido/total"
```

## Tecnologias Utilizadas

- **C#** e **ASP.NET Core**
- **Swagger/OpenAPI** para documentação
- **REST API** para comunicação
- **POO** para arquitetura do projeto

## Arquivo de Testes

Para testar a API, consulte o arquivo `POO-ClientePedido.http` que contém exemplos de requisições.
