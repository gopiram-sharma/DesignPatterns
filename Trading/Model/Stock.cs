namespace Trading.Model;
using System;
using System.Collections.Generic;
using Trading.Model.Events;

public class Stock
{
    public string Ticker { get; set; }
    public string Name { get; set; }
    public decimal CurrentPrice { get; private set; }

    private Random _random = new Random();

    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    public Stock(string ticker, string name, decimal initialPrice)
    {
        Ticker = ticker;
        Name = name;
        CurrentPrice = initialPrice;
    }

    public void UpdatePrice()
    {
        decimal oldPrice = CurrentPrice;
        decimal change = (decimal)(_random.NextDouble() * 10 - 5); // Random change between -5 and +5
        CurrentPrice = Math.Max(0, CurrentPrice + change); // Ensure price doesn't go negative
        if(CurrentPrice != oldPrice)
        {
            PriceChanged?.Invoke(this, new PriceChangedEventArgs(oldPrice, CurrentPrice));
        }
    }

    public override string ToString() => $"{Ticker} - {Name}: ${CurrentPrice:F2}";
}