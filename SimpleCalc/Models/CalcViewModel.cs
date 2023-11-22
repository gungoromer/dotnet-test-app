using System.ComponentModel.DataAnnotations;

namespace SimpleCalc.Models
{
    public class CalcViewModel
    {
        [Display(Name = "Number 1")]
        public int Number1 { get; set; }

        [Display(Name = "Number 2")]
        public int Number2 { get; set; }

        public double Result { get; set; }
    }
}