using System.ComponentModel.DataAnnotations;

namespace peractice1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
