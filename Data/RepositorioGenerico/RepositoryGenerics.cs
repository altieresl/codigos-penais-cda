using Business.InterfaceGenerica;
using Data.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositorioGenerico
{
    public class RepositoryGenerics<T> : IGeneric<T>, IDisposable where T : class
    {
        private Component component = new Component();
        private bool disposed = false;

        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryGenerics()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task Add(T Objeto)
        {
            using (var db = new DbContext(_OptionsBuilder))
            {
                await db.Set<T>().AddAsync(Objeto);
                await db.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var db = new DbContext(_OptionsBuilder))
            {
                db.Set<T>().Remove(Objeto);
                await db.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var db = new DbContext(_OptionsBuilder))
            {
                return await db.Set<T>().FindAsync(Id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var db = new DbContext(_OptionsBuilder))
            {
                return await db.Set<T>().ToListAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var db = new DbContext(_OptionsBuilder))
            {
                db.Set<T>().Update(Objeto);
                await db.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    component.Dispose();
                }

                // Note disposing has been done.
                disposed = true;
            }
        }

    }
}
