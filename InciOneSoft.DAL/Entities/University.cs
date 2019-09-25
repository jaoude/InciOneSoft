using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.DAL.Entities
{
    [Table("University")]
    public class University
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(UNIVERSITY_NAME_CHAR_LEN)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ADDRESS_CHAR_LEN)]
        public string Address { get; set; }

        public ICollection<Faculty> Faculties { get; set; }
    }
}
