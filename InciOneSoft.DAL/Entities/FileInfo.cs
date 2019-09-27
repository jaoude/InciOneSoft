using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.DAL.Entities
{

    [Table("FileInfo")]
    public class FileInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [MaxLength(FILEINFO_LEN)]
        public string Export { get; set; }

        [MaxLength(FILEINFO_LEN)]
        public string Version { get; set; }
       
        [MaxLength(FILEINFO_LEN)]
        public string FactureNonSoldees { get; set; }
       
       
        public DateTime FileDateHour { get; set; }

        public DateTime UploadedDate { get; set; }

        public string UploadedByUserName { get; set; }
    }
}
