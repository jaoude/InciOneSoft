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
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(InciOneSoftDbContext _db)
            : base(_db)
        {
        }
    }
}
