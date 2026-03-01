namespace Lureya.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";  // "Hijab" | "Abaya"
    public string SubCategory { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public decimal? OldPrice { get; set; }
    public string ImageUrl { get; set; } = "";
    public List<string> GalleryImages { get; set; } = new();
    public List<string> Colors { get; set; } = new();
    public List<string> Sizes { get; set; } = new();
    public string Badge { get; set; } = "";  // "Nieuw" | "Sale" | ""
    public bool IsFeatured { get; set; }
    public double Rating { get; set; }
    public int ReviewCount { get; set; }
    public string Material { get; set; } = "";
}

public class CartItem
{
    public Product Product { get; set; } = new();
    public int Quantity { get; set; }
    public string SelectedColor { get; set; } = "";
    public string SelectedSize { get; set; } = "";

    public decimal LineTotal => Product.Price * Quantity;
}
