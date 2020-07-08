using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        //Pedido pode ter, pelo menos um
        //Ou muitos pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
            {
                AdicionarMensagensValidacao("Pedido não pode ficar sem Item de Pedido");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarMensagensValidacao("CEP deve estar preenchido");
            }

        }
    }
}
