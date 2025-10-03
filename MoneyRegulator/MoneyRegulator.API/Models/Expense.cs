using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyRegulator.API.Models
{
    [Table(name: "Expenses")]
    public class Expense
    {
        public int Id { get; set; }

        [StringLength(30), Required]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)"), Required]
        public decimal Amount { get; set; }

        [Required]
        public Category Category { get; set; } = default!;


        // Navigation property - relation with Category
        [Required]
        public int CategoryId { get; set; } = 1;

    }
}
