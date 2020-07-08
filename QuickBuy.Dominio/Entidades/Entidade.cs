using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mesagensValidacao { get; set; }

        private List<string> mensagemValidacao
        {
            get { return _mesagensValidacao ?? (_mesagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMensagensValidacao(string msgvalidacao)
        {
            mensagemValidacao.Add(msgvalidacao);
        }
        public abstract void Validate();

        public bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
