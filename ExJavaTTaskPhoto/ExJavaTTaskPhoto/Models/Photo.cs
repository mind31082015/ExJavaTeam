using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExJavaTeam.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public virtual User Owner { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}