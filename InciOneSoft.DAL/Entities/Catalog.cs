using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.DAL.Entities
{
    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int SchoolYear { get; set; }

        [Required]
        public string PEOs { get; set; }
    }
}
