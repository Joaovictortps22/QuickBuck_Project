using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contrato
{
    //Interface de nome (IBaseRepositorio), vai trabalhar com o TEntity, ela erda de outra Interface (IDisposable), informo que TEntity é um class
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);

        TEntity ObterPorId(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);
    }
}
