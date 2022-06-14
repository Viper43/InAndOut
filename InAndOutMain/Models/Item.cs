using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOutMain.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Borrower")]
        public string Borrower { get; set; }
        
        [Required]
        [DisplayName("Lender")]
        public string Lender { get; set; }

        [Required]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DisplayName("Borrow Date")]
        public DateTime BorrowedDate { get; set; }
    }
}
