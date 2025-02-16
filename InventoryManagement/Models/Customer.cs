using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int CustomerID { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Contact { get; set; }

    public int LoyaltyPoints { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}

