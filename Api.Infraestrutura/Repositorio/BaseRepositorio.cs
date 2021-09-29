using Api.Domain.Models;
using Api.Infraestrutura.Contexto;
using Api.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Infraestrutura.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ApiContexto ApiContexto;
        public BaseRepositorio(ApiContexto apicontexto)
        {
            ApiContexto = apicontexto;
        }
        public void Adicionar(TEntity entity)
        {
            ApiContexto.Set<TEntity>().Add(entity);
            ApiContexto.SaveChanges();
        }
        public void Atualizar(Clientes cliente)
        {
            
            ApiContexto.Update(cliente);
            ApiContexto.SaveChanges();
        }
        public TEntity ObterPorId(int Id)
        {
            return ApiContexto.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()

        {
            return ApiContexto.Set<TEntity>().ToList();
        }

        public void Remover(int id)
        {
       
            var obj = ObterPorId(id);
            ApiContexto.Remove(obj);
            ApiContexto.SaveChanges();

        }
        public void Dispose()
        {
            ApiContexto.Dispose();
        }   
    }
    }