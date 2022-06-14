using System.ComponentModel.DataAnnotations;

namespace InAndOutMain.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ExpenseTypeName { get; set; }
    }
}
