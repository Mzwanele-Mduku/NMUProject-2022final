using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Innovators.Models
{
    public class AssignLecturer
    {
        [Key]
        public int LecturerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        [DisplayName("Email Address")]
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Course { get; set; }
        [Required]
        public string Module { get; set; }
        [DisplayName("Cell Number")]
        [Required]
        public string CellNumber { get; set; }
    }
}
