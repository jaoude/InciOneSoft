using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InciOneSoft.DAL.Entities
{
    public class Faculty : University
    {
        [ForeignKey("UniversityId")]
        public University University { get; set; }
        public Guid? UniversityId { get; set; }

        public ICollection<Institution> Institutions { get; set; }
    }

}
