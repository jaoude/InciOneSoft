using InciOneSoft.DAL.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InciOneSoft.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICatalogRepository Catalogs { get; }
        IUniversityRepository Universities { get; }
        ICourseRepository Courses { get; }
        IInstitutionRepository Institutions { get; }
        IProgrammRepository Programms { get; }
        IPersonRepository Persons { get; }

        Task<int> SaveChangesAsync(CancellationToken ct);

        int SaveChanges();
        
    }
}
