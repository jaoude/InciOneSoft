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
    public class FileInfoRepository : Repository<Entities.FileInfo>, IFileInfoRepository
    {
        //private InciOneSoftDbContext _context;

        public FileInfoRepository(InciOneSoftDbContext _db)
            : base(_db)
        {
        }

        
    }
}
