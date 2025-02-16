using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int UserID { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Role { get; set; }

    [Required]
    public required string PasswordHash { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}

