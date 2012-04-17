using System.Linq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services
{
    public class RoleService : IRoleService
    {
        private IDALContext _context;
        public RoleService(IDALContext context)
        {
            _context = context;
        }

        public IQueryable<Role> GetAllRoles()
        {
            return _context.RoleRepository.GetAll();
        }
    }
}
