using ControleEmprestimo.Data.Interfaces;
using ControleEmprestimo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleEmprestimo.Data.Repositories
{

    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected GestaobibliotecaContext _context;
        public bool _SaveChanges = true;

        ////public RepositoryBase(GestaobibliotecaContext context, bool saveChanges)
        ////{
        ////    _context = context;
        ////    _SaveChanges = saveChanges;
        ////}

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _context = new GestaobibliotecaContext();
        }


        public T Alterar(T objeto)
        {
            _context.Entry(objeto).State = EntityState.Modified;
            if (_SaveChanges)
            {
                _context.SaveChanges();
            }
            return objeto;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Excluir(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPK(variavel);
            Excluir(obj);            
        }

        public T Incluir(T objeto)
        {
              _context.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _context.SaveChanges();
            }
            return objeto;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public T SelecionarPK(params object[] variavel)
        {
            return _context.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _context.Set<T>().ToList();
        }
    }
}
