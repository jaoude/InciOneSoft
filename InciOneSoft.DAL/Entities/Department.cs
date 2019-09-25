using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InciOneSoft.DAL.Entities
{
    public class Department : University
    {
        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
 
        public Guid? InstitutionId { get; set; }
    }

}
