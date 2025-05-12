namespace MerchStore.WebUI.Models.Cart;

public class ShippingInfo
{
    public string Förnamn { get; set; } = string.Empty;
    public string Efternamn { get; set; } = string.Empty;
    public string Gatuadress { get; set; } = string.Empty;

    public string Postnummer { get; set; } = string.Empty;
    public string Stad { get; set; } = string.Empty;
    public string Telefonnummer { get; set; } = string.Empty;
    public string Land { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string Fraktmetod { get; set; } = string.Empty;
    public string Betalningsmetod { get; set; } = string.Empty;
}
