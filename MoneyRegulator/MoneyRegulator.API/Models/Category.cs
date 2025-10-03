using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyRegulator.API.Models
{
    [Table(name: "Categories")]
    public class Category
    {

        public int Id { get; set; }

        [StringLength(30), Required]
        public string Name { get; set; } = string.Empty;


        // Inverse navigation property - relation with Expense
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    }
}
