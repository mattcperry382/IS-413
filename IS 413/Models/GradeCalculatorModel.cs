using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413.Models
{
    public class GradeCalculatorModel
    {
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public decimal Assignments { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public decimal GroupProject { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public decimal Quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public decimal Exams { get; set; }
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public decimal Intex { get; set; }
    }
}
