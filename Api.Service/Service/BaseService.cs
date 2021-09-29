using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        public readonly IBaseRepositorio<TEntity> _db;

        public BaseService(IBaseRepositorio<TEntity> db)
        {
            _db = db;
        }
        public void Adicionar(TEntity entity)
        {
            _db.Adicionar(entity);
        }

        public void Atualizar(Clientes cliente)
        {
            _db.Atualizar(cliente);
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return _db.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _db.ObterTodos();
        }

        public void Remover(int id)
        {
            _db.Remover(id);
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
