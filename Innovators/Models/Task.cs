using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Innovators.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        [Required(ErrorMessage ="Insert Task name")]
        
        public string TaskName { get; set; }
        [Required(ErrorMessage ="Task Description")]
        public string TaskDescription { get; set; }
        public string DueDate { get; set; }
        public string SetDate { get; set; }
        public string Status { get; set; }
        public string Document { get; set; }
    }
}
