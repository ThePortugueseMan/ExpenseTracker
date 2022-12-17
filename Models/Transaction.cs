using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime TransDate  { get; set; }
        public string? Category { get; set; }
        [Column(TypeName ="decimal  (18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Value { get; set; }
    }
}
