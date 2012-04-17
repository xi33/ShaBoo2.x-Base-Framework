using System;
using ShaBoo.Domain.Repositories;
using ShaBoo.EFRepositories.Moqs;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class DALContext : IDALContext
    {
        #region fields

        private readonly ShaBooContainer _context;
        private IRoleRepository _roleRepository;

        #endregion

        #region ctor

        public DALContext()
        {
            _context = new ShaBooContainer();
        }

        #endregion

        #region Repositories

        public IRoleRepository RoleRepository
        {
            get
            {
                //return _roleRepository ?? (_roleRepository = new RoleRepository(_context));
                //这个最好创建一个Unit Test，暂时还不熟悉。
                return MoqRoleRepository.Load();
            }
        }

        #endregion

        #region Unit of Work

        private bool _disposed;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        #endregion
    }
}