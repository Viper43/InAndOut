using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOutMain.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }
        
        [DisplayName("Amount")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0!")]
        public int Amount { get; set; }

        [DisplayName("Date")]
        [Required]
        public DateTime ExpenseDate { get; set; }

        [DisplayName("Expense Type")]
        public int ExpenseTypeId { get; set; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
