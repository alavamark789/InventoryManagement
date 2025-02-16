using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Category
{
    [Key]
    public int CategoryID { get; set; }

    [Required]
    public required string Name { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
