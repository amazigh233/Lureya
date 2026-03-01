using Lureya.Models;

namespace Lureya.Services;

public class CartService
{
    private readonly List<CartItem> _items = new();

    public event Action? OnChange;

    public IReadOnlyList<CartItem> Items => _items.AsReadOnly();

    public int TotalCount => _items.Sum(i => i.Quantity);

    public decimal Subtotal => _items.Sum(i => i.LineTotal);

    public decimal Shipping => Subtotal >= 75 ? 0 : 4.95m;

    public decimal Total => Subtotal + Shipping;

    public void AddToCart(Product product, string color = "", string size = "")
    {
        var existing = _items.FirstOrDefault(i =>
            i.Product.Id == product.Id &&
            i.SelectedColor == color &&
            i.SelectedSize == size);

        if (existing != null)
            existing.Quantity++;
        else
            _items.Add(new CartItem { Product = product, Quantity = 1, SelectedColor = color, SelectedSize = size });

        NotifyChanged();
    }

    public void RemoveFromCart(CartItem item)
    {
        _items.Remove(item);
        NotifyChanged();
    }

    public void UpdateQuantity(CartItem item, int delta)
    {
        item.Quantity += delta;
        if (item.Quantity <= 0)
            _items.Remove(item);
        NotifyChanged();
    }

    public void Clear()
    {
        _items.Clear();
        NotifyChanged();
    }

    private void NotifyChanged() => OnChange?.Invoke();
}
