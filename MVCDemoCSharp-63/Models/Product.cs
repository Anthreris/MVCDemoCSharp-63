namespace MVCDemoCSharp_63.Models;

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    // [Required(ErrorMessage = "Product Name is required")]
    // [StringLength(100)]
    // public string Name { get; set; } = string.Empty;
    //
    // [Required]
    // [Range(0, double.MaxValue, ErrorMessage = "Price must be zero or greater.")]
    public double Price { get; set; }
    public int CategoryID { get; set; }
    public bool OnSale { get; set; }
    public int StockLevel { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}