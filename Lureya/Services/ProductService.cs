using Lureya.Models;

namespace Lureya.Services;

public class ProductService
{
    private readonly List<Product> _products = new()
    {
        // ── HIJABS ──
        new Product
        {
            Id = 1,
            Name = "Silk Chiffon Hijab",
            Category = "Hijab",
            SubCategory = "Chiffon",
            Description = "Onze bestseller – lichtgewicht, vloeiende chiffon hijab die stijlvol drapeert. Ideaal voor zowel dagelijks gebruik als speciale gelegenheden.",
            Price = 34.95m,
            ImageUrl = "https://images.unsplash.com/photo-1594938298603-c8148c4b4869?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1594938298603-c8148c4b4869?w=600&auto=format&fit=crop&q=80",
                "https://images.unsplash.com/photo-1583623025817-d180a2221d0a?w=600&auto=format&fit=crop&q=80"
            },
            Colors = new() { "#FAF6EF", "#C4A265", "#2D1F0E", "#8B7355", "#DDD5C8" },
            Sizes = new() { "S", "M", "L", "XL" },
            Badge = "Nieuw",
            IsFeatured = true,
            Rating = 4.9,
            ReviewCount = 142,
            Material = "100% Chiffon"
        },
        new Product
        {
            Id = 2,
            Name = "Satin Luxe Hijab",
            Category = "Hijab",
            SubCategory = "Satin",
            Description = "Elegante satijnen hijab met een zachte glans. Perfect voor bruidsfeesten en speciale evenementen. Voelt zijdezacht aan de huid.",
            Price = 44.95m,
            OldPrice = 59.95m,
            ImageUrl = "https://images.unsplash.com/photo-1558769132-cb1aea458c5e?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1558769132-cb1aea458c5e?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#FFFFFF", "#FAF6EF", "#C4A265", "#B8B8D0", "#E8C5C5" },
            Sizes = new() { "Universeel" },
            Badge = "Sale",
            IsFeatured = true,
            Rating = 4.8,
            ReviewCount = 98,
            Material = "100% Satijn"
        },
        new Product
        {
            Id = 3,
            Name = "Jersey Premium Hijab",
            Category = "Hijab",
            SubCategory = "Jersey",
            Description = "Comfortabele jersey hijab met stretch die de hele dag op zijn plek blijft. Geen spelden nodig – moeiteloos stijl.",
            Price = 24.95m,
            ImageUrl = "https://images.unsplash.com/photo-1529139574466-a303027c1d8b?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1529139574466-a303027c1d8b?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#2D1F0E", "#FAF6EF", "#6B5540", "#E8D5BB", "#A08870" },
            Sizes = new() { "S/M", "L/XL" },
            Badge = "",
            IsFeatured = true,
            Rating = 4.7,
            ReviewCount = 215,
            Material = "95% Viscose | 5% Elastaan"
        },
        new Product
        {
            Id = 4,
            Name = "Embroidered Hijab",
            Category = "Hijab",
            SubCategory = "Borduurwerk",
            Description = "Verfijnd geborduurde hijab met gouden accenten. Een kunstwerk dat elegantie en traditie combineert.",
            Price = 54.95m,
            ImageUrl = "https://images.unsplash.com/photo-1583500178690-594ce8aa3a6e?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1583500178690-594ce8aa3a6e?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#FAF6EF", "#DFC28A", "#E8D5BB" },
            Sizes = new() { "Universeel" },
            Badge = "Nieuw",
            IsFeatured = false,
            Rating = 4.9,
            ReviewCount = 67,
            Material = "Chiffon met borduurwerk"
        },
        new Product
        {
            Id = 5,
            Name = "Linen Blend Hijab",
            Category = "Hijab",
            SubCategory = "Linnen",
            Description = "Ademende linnen blend hijab voor warme dagen. Natuurlijke textuur, minimalistische stijl.",
            Price = 29.95m,
            ImageUrl = "https://images.unsplash.com/photo-1490481651871-ab68de25d43d?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1490481651871-ab68de25d43d?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#E4D3BE", "#A08870", "#DDD5C8", "#8B7B6B" },
            Sizes = new() { "Universeel" },
            Badge = "",
            IsFeatured = false,
            Rating = 4.6,
            ReviewCount = 53,
            Material = "55% Linnen | 45% Katoen"
        },
        new Product
        {
            Id = 6,
            Name = "Velvet Evening Hijab",
            Category = "Hijab",
            SubCategory = "Fluweel",
            Description = "Luxueus fluwelen hijab voor avondgelegenheden. De rijke textuur geeft diepte en elegantie.",
            Price = 49.95m,
            ImageUrl = "https://images.unsplash.com/photo-1539109136881-3be0616acf4b?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1539109136881-3be0616acf4b?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#2D1F0E", "#6B5540", "#C4A265", "#8B3A3A" },
            Sizes = new() { "Universeel" },
            Badge = "Nieuw",
            IsFeatured = true,
            Rating = 4.8,
            ReviewCount = 44,
            Material = "100% Fluweel"
        },

        // ── ABAYAS ──
        new Product
        {
            Id = 7,
            Name = "Classic Open Abaya",
            Category = "Abaya",
            SubCategory = "Klassiek",
            Description = "Tijdloze open abaya in premium crêpe. Vloeit langs het lichaam en biedt een perfecte mix van comfort en elegantie.",
            Price = 129.95m,
            ImageUrl = "https://images.unsplash.com/photo-1701004619754-c3a8ee9a0d67?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1701004619754-c3a8ee9a0d67?w=600&auto=format&fit=crop&q=80",
                "https://images.unsplash.com/photo-1583623025817-d180a2221d0a?w=600&auto=format&fit=crop&q=80"
            },
            Colors = new() { "#2D1F0E", "#FAF6EF", "#6B5540", "#3D4A5C" },
            Sizes = new() { "XS", "S", "M", "L", "XL", "XXL" },
            Badge = "Nieuw",
            IsFeatured = true,
            Rating = 4.9,
            ReviewCount = 188,
            Material = "Premium Crêpe"
        },
        new Product
        {
            Id = 8,
            Name = "Embroidered Luxury Abaya",
            Category = "Abaya",
            SubCategory = "Borduurwerk",
            Description = "Prachtig goud geborduurde abaya – een meesterwerk van vakmanschap. Gemaakt voor bijzondere momenten die je leven kleur geven.",
            Price = 199.95m,
            OldPrice = 249.95m,
            ImageUrl = "https://images.unsplash.com/photo-1583500178690-594ce8aa3a6e?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1583500178690-594ce8aa3a6e?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#2D1F0E", "#3D4A5C", "#4A3728" },
            Sizes = new() { "XS", "S", "M", "L", "XL" },
            Badge = "Sale",
            IsFeatured = true,
            Rating = 5.0,
            ReviewCount = 76,
            Material = "Crêpe met goudborduarsel"
        },
        new Product
        {
            Id = 9,
            Name = "Butterfly Sleeve Abaya",
            Category = "Abaya",
            SubCategory = "Vlindermouwen",
            Description = "Romantische vlindermowen abaya die vloeiend beweegt bij elke stap. Modern silhouet met een verfijnde afwerking.",
            Price = 154.95m,
            ImageUrl = "https://images.unsplash.com/photo-1529139574466-a303027c1d8b?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1529139574466-a303027c1d8b?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#FAF6EF", "#6B5540", "#2D1F0E", "#DDD5C8" },
            Sizes = new() { "XS", "S", "M", "L", "XL", "XXL" },
            Badge = "",
            IsFeatured = false,
            Rating = 4.7,
            ReviewCount = 95,
            Material = "Crêpe Georgette"
        },
        new Product
        {
            Id = 10,
            Name = "Sport Modest Abaya",
            Category = "Abaya",
            SubCategory = "Sport",
            Description = "Actieve abaya voor de moderne vrouw in beweging. Lichtgewicht, ademend en vrij in elke beweging.",
            Price = 89.95m,
            ImageUrl = "https://images.unsplash.com/photo-1558769132-cb1aea458c5e?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1558769132-cb1aea458c5e?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#2D1F0E", "#3D4A5C", "#4B5E4A" },
            Sizes = new() { "XS", "S", "M", "L", "XL" },
            Badge = "Nieuw",
            IsFeatured = false,
            Rating = 4.6,
            ReviewCount = 62,
            Material = "Technische Stof"
        },
        new Product
        {
            Id = 11,
            Name = "Linen Breeze Abaya",
            Category = "Abaya",
            SubCategory = "Linnen",
            Description = "Zomerse linnen abaya voor warme dagen. Ruim en luchtig met een casual chic uitstraling.",
            Price = 119.95m,
            ImageUrl = "https://images.unsplash.com/photo-1490481651871-ab68de25d43d?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1490481651871-ab68de25d43d?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#E4D3BE", "#FAF6EF", "#A08870" },
            Sizes = new() { "XS", "S", "M", "L", "XL", "XXL" },
            Badge = "",
            IsFeatured = false,
            Rating = 4.8,
            ReviewCount = 118,
            Material = "Premium Linnen"
        },
        new Product
        {
            Id = 12,
            Name = "Bridal Silk Abaya",
            Category = "Abaya",
            SubCategory = "Bruidscollectie",
            Description = "Onze exclusieve bruids abaya – een meesterwerk van pure zijde en handgeborduurde details. Voor de mooiste dag van je leven.",
            Price = 299.95m,
            ImageUrl = "https://images.unsplash.com/photo-1539109136881-3be0616acf4b?w=600&auto=format&fit=crop&q=80",
            GalleryImages = new() {
                "https://images.unsplash.com/photo-1539109136881-3be0616acf4b?w=600&auto=format&fit=crop&q=80",
            },
            Colors = new() { "#FAF6EF", "#DFC28A", "#F8F0E8" },
            Sizes = new() { "XS", "S", "M", "L", "XL" },
            Badge = "Nieuw",
            IsFeatured = true,
            Rating = 5.0,
            ReviewCount = 34,
            Material = "Pure Zijde"
        },
    };

    public List<Product> GetAll() => _products;

    public List<Product> GetFeatured() => _products.Where(p => p.IsFeatured).Take(6).ToList();

    public List<Product> GetByCategory(string category) =>
        string.IsNullOrEmpty(category) || category == "Alles"
            ? _products
            : _products.Where(p => p.Category == category).ToList();

    public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

    public List<Product> Search(string query) =>
        _products.Where(p =>
            p.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            p.Category.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            p.SubCategory.Contains(query, StringComparison.OrdinalIgnoreCase)
        ).ToList();
}
