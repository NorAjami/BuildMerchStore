namespace MerchStore.Domain.ValueObjects;

public record Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative");
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency code must be 3 letters (ISO 4217)");

        Amount = amount;
        Currency = currency.ToUpper();
    }

    public static Money FromSEK(decimal amount) => new Money(amount, "SEK");

    public static Money operator +(Money a, Money b)
    {
        if (a.Currency != b.Currency)
            throw new InvalidOperationException("Currencies must match");
        return new Money(a.Amount + b.Amount, a.Currency);
    }

    public static Money operator *(Money money, int quantity) =>
        new Money(money.Amount * quantity, money.Currency);

    public static Money operator *(int quantity, Money money) =>
        money * quantity;

    public override string ToString() =>
        $"{Amount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} {Currency}";
}
