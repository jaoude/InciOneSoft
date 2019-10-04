using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InciOneSoft.DAL.DBContext;
using InciOneSoft.DAL.Entities;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace InciOneSoft.DAL.Repositories
{
    public class FileDataRepository : Repository<FileData>, IFileDataRepository
    {
        //private InciOneSoftDbContext _context;

        public FileDataRepository(InciOneSoftDbContext _db)
            : base(_db)
        {
        }

        public async Task UploadAsync(byte[] fileBytesArray, Guid fileInfoId, string userName, CancellationToken ct)
        {
            var fileDataEntities = new FileData();
            using (TextFieldParser parser = new TextFieldParser(new MemoryStream(fileBytesArray)))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    var fileDataEntity = MapInputCsvLineToFileData(fields);
                  
                }
            }
        }

        private FileData MapInputCsvLineToFileData(string[] fields)
        {
            return new FileData()
            {

            };
        }


        //public async Task<Person> GetPersonAsync(Guid id, CancellationToken ct)
        //{
        //    return await _db.Set<Person>().FirstOrDefaultAsync(ct);
        //}

        //public async Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct)
        //{
        //    return await _db.Set<Person>().ToListAsync(ct);
        //}

        //public void CreatePerson(Person personEntity)
        //{
        //     _db.Set<Person>().Add(personEntity);
        //}
    }
}
