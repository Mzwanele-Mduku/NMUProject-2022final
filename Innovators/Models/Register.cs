using System.ComponentModel.DataAnnotations;

namespace Innovators.Models
{
    public class Register
    {
        [Key]
        public int RegId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Date{ get; set; }
        public string Attended { get; set; }
        public string Absent { get; set; }
    } 
}
