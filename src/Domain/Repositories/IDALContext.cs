using System;

namespace ShaBoo.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }

    public interface IDALContext : IUnitOfWork
    {
        IRoleRepository RoleRepository { get; }
    }
}