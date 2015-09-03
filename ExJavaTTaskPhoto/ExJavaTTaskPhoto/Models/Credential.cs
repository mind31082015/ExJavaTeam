using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExJavaTeam.Models
{
    [NotMapped]
    public class Credential
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

    }
}