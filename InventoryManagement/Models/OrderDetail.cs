using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class OrderDetail
{
    [Key]
    public int OrderDetailID { get; set; }

    [ForeignKey("Order")]
    public int OrderID { get; set; }

    [ForeignKey("Product")]
    public int ProductID { get; set; }

    public required Order Order { get; set; }

    public required Product Product { get; set; }

    public int Quantity { get; set; }

    public decimal Subtotal { get; set; }
}
