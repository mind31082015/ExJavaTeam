using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.ComponentModel.DataAnnotations;

namespace ExJavaTeam.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Photo Photo { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Enter the comment about this photo")]
        public string Message { get; set; }

        [Required]
        public virtual User User { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}",
            ApplyFormatInEditMode = true)]
        [Required]
        public DateTime Date { get; set; }
    }
}