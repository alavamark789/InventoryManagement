using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CategoryID { get; set; }
    public int SupplierID { get; set; }
    public decimal Price { get; set; }
    public int StockQty { get; set; }

    // Navigation properties
    public Category? Category { get; set; }
    public Supplier? Supplier { get; set; }



    public required ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

}
