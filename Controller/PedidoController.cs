using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POO_ClientePedido.Models;

namespace POO_ClientePedido.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private static Pedido _pedido = new Pedido();

        [HttpPost("adicionar")]
        public IActionResult AdicionarItem([FromBody] ItemPedido item)
        {
            _pedido.AdicionarPedido(item);
            return Ok("Item adicionado ao pedido.");
        }

        [HttpDelete("remover")]
        public IActionResult RemoverItem([FromBody] ItemPedido item)
        {
            _pedido.RemoverPedido(item);
            return Ok("Item removido do pedido.");
        }

        [HttpGet("listar")]
        public IActionResult ListarPedidos()
        {
            var itens = _pedido.Itens;
            return Ok(itens);
        }

        [HttpDelete("limpar")]
        public IActionResult LimparPedido([FromBody] ItemPedido item)
        {
            _pedido.LimparPedidos();
            return Ok("Pedido limpo.");
        }

        [HttpPut("atualizar/{index}")]
        public IActionResult AtualizarPedido(int index, [FromBody] ItemPedido novoItem)
        {
            _pedido.AtualizarPedido(index, novoItem);
            return Ok("Pedido atualizado.");
        }

        [HttpGet("buscar")]
        public IActionResult BuscarPedido([FromQuery] string nomeProduto)
        {
            var itensEncontrados = _pedido.Itens.Where(item => item.NomeProduto.Contains(nomeProduto)).ToList();
            return Ok(itensEncontrados);
        }

        [HttpGet("total")]
        public IActionResult CalcularTotal()
        {
            double total = _pedido.CalcularTotal();
            return Ok(new { total = total });
        }

    }
}