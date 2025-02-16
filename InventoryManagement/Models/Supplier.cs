using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Supplier
{
    [Key]
    public int SupplierID { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
   

    public ICollection<Product> Products { get; set; } = new List<Product>();
}


