using InciOneSoft.DAL.DBContext;
using InciOneSoft.DAL.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace InciOneSoft.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InciOneSoftDbContext _db;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(InciOneSoftDbContext db,
            IServiceProvider serviceProvider)
        {
            _db = db;
            _serviceProvider = serviceProvider;
        }

        public IPersonRepository Persons => _serviceProvider.GetService<IPersonRepository>();
        public IFileInfoRepository FileInfos => _serviceProvider.GetService<IFileInfoRepository>();

        public async Task<int> SaveChangesAsync(CancellationToken ct)
        {
            return await _db.SaveChangesAsync(ct);
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
