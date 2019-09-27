using InciOneSoft.DAL.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InciOneSoft.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        IFileInfoRepository FileInfos { get; }
        Task<int> SaveChangesAsync(CancellationToken ct);

        int SaveChanges();
        
    }
}
