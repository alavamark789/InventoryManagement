using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Order
{
    [Key]
    public int OrderID { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }

    public required Customer Customer { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
