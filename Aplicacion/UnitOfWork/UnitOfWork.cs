

using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbAppContext _context;
        public UnitOfWork(DbAppContext context)
        {
            _context = context;
        }
    } 