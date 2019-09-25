using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.DAL.Entities
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FIRST_NAME_CHAR_LEN)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(LAST_NAME_CHAR_LEN)]
        public string LastName { get; set; }

        [MaxLength(LAST_NAME_CHAR_LEN)]
        public string Address { get; set; }
    }
}
