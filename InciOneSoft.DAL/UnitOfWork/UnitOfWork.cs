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

        public ICatalogRepository Catalogs => _serviceProvider.GetService<ICatalogRepository>();
        public IUniversityRepository Universities => _serviceProvider.GetService<IUniversityRepository>();
        public ICourseRepository Courses => _serviceProvider.GetService<ICourseRepository>();
        public IInstitutionRepository Institutions => _serviceProvider.GetService<IInstitutionRepository>();
        public IProgrammRepository Programms => _serviceProvider.GetService<IProgrammRepository>();
        public IPersonRepository Persons => _serviceProvider.GetService<IPersonRepository>();

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
