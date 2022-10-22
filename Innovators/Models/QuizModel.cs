using System.ComponentModel.DataAnnotations;

namespace Innovators.Models
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }
        public string Excecise { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }

        public string Q3 { get; set; }

        public string Q4 { get; set; }

        public string Q5 { get; set; }
        public int Grade { get; set; }

        public string Memo1 { get; set; }
        public string Memo2 { get; set; }

        public string Memo3 { get; set; }

        public string Memo4 { get; set; }

        public string Memo5 { get; set; }

        public string A1 { get; set; }
        public string A2 { get; set; }

        public string A3 { get; set; }

        public string A4 { get; set; }

        public string A5 { get; set; }
        public int Total { get; set; }


    }
}
