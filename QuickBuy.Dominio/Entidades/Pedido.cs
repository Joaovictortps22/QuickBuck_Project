using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        //Pedido pode ter, pelo menos um
        //Ou muitos pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
