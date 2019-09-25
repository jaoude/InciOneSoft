using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.DAL.Entities
{
    [Table("Porgramm")]
    public class Programm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PROGRAMM_CODE_CHAR_LEN)]
        public string Code { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int NumberOfCredits { get; set; }

        [Required]
        public int NumberOfSemesters { get; set; }

        [Required]
        [MaxLength(PROGRAMM_DIPLOMA_CHAR_LEN)]
        public string Diploma { get; set; }
    }
}
