using System.Collections.Generic;
using MerchStore.WebUI.Models.Catalog;


namespace MerchStore.WebUI.Models.Cart;

public class CartViewModel
{
    public List<ShoppingCartItem> Items { get; set; } = new();
    public ShippingInfo Shipping { get; set; } = new(); // ✅ aldrig null

    

    public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);
    public int TotalQuantity => Items.Sum(item => item.Quantity);
    public string? SuccessMessage { get; set; } = string.Empty; 
    public string? ErrorMessage { get; set; } = string.Empty;
    public string? WarningMessage { get; set; } = string.Empty;

}
