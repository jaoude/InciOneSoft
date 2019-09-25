using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.DAL.Entities
{
    [Table("Institution")]
    public class Institution : University
    {
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }
        public Guid? FacultyId { get; set; }

        [Required]
        public int EvaluationType { get; set; }

        public ICollection<Department> Departments { get; set; }
    }

}
