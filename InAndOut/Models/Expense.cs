using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Expense Name")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Invalid Cost")]
        public int Cost { get; set; }
    }
}
