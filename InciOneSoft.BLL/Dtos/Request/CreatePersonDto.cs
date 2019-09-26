using System;
using System.ComponentModel.DataAnnotations;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.BLL.Dtos
{
    public class CreatePersonDto
    {
        [Required]
        [MaxLength(NAME_CHAR_LEN)]
        [Display(Name = DISPLAY_PERSON_FIRST_NAME)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(NAME_CHAR_LEN)]
        [Display(Name = DISPLAY_PERSON_LAST_NAME)]
        public string LastName { get; set; }
    }
}