using System;
using System.ComponentModel.DataAnnotations;
using static InciOneSoft.Common.Constants;

namespace InciOneSoft.BLL.Dtos
{
    public class PersonDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}