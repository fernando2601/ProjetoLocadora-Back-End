using Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Interface
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);

        TEntity ObterPorId(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(Clientes cliente);

        void Remover(int id);
    }
}
