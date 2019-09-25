using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InciOneSoft.DAL.DBContext;
using InciOneSoft.DAL.Entities;

namespace InciOneSoft.DAL.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private InciOneSoftDbContext _context;

        public PersonRepository(InciOneSoftDbContext _db)
            : base(_db)
        {
        }

        public async Task<Person> GetPersonAsync(Guid id, CancellationToken ct)
        {
            return await _db.Set<Person>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct)
        {
            return await _db.Set<Person>().ToListAsync(ct);
        }

        public void CreatePerson(Person personEntity)
        {
             _db.Set<Person>().Add(personEntity);
        }
    }
}
