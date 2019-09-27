using InciOneSoft.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InciOneSoft.DAL.Repositories
{
    public interface IFileInfoRepository : IRepository<FileInfo>
    {
        //Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct);
        //Task<Person> GetPersonAsync(Guid id, CancellationToken ct);

        //void CreatePerson(Person personEntity);

    }
}