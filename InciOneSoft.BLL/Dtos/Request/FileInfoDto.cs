using System;
using System.ComponentModel.DataAnnotations;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.BLL.Dtos.Request
{
    public class FileInfoDto
    {
        public string Export { get; set; }
        [MaxLength(FILEINFO_LEN)]
        public string Version { get; set; }
        [MaxLength(FILEINFO_LEN)]
        public string FactureNonSoldees { get; set; }
        [MaxLength(FILEINFO_LEN)]
        public DateTime dateHour { get; set; }   
    }
}
