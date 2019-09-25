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
    public class CatalogRepository : Repository<Catalog>, ICatalogRepository
    {
        public CatalogRepository(InciOneSoftDbContext _db)
            : base(_db)
        {


        }
    }
}
