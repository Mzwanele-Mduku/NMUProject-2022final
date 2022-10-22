using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace Innovators.Models
{
    public class Report
    {
        [Key]
        public int ModuleId { get; set; }
        [DisplayName("Module")]
        public string ModuleName { get; set; }
        public string Course { get; set; }
        [DisplayName("Name")]
        public string StudentName { get; set; }
        [DisplayName("Surname")]
        public string StudentSurname { get; set; }
        [DisplayName("Student Number")]
        public int StudentNumber { get; set; }
        [DisplayName("Test 1")]
        public int Test1 { get; set; }
        [DisplayName("Test 2")]
        public int Test2 { get; set; }
        [DisplayName("Test 3")]
        public int Test3 { get; set; }
        public int Average { get; set; }
    }
}
