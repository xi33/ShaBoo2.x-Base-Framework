using System;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.EFRepositories;

namespace ShaBoo.Services
{
    public class BLLService : IBLLService, IDisposable
    {
        #region fields
        private IDALContext _context;
        private IRoleService _roleService;
        #endregion

        #region ctor
        public BLLService()
        {
            _context = new DALContext();
        }
        #endregion

        #region Services
        public IRoleService RoleService
        {
            get { return _roleService ?? (_roleService = new RoleService(_context)); }
        }
        #endregion

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
