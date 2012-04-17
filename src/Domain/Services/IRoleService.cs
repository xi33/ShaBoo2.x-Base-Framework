using System.Linq;
using ShaBoo.Entities;

namespace ShaBoo.Domain.Services
{
    public interface IRoleService
    {
        IQueryable<Role> GetAllRoles();
    }
}