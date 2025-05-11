namespace Trading.Model;
using System;
using System.Collections.Generic;
using Trading.Model.Events;

public class Market
{
    private List<Trader> _traders = new List<Trader>();

    private List<Stock> _stocks = new List<Stock>();

    public void SeedStocks()
    {
        _stocks.Add(new Stock("AAPL", "Apple Inc.", 150.00m));
        _stocks.Add(new Stock("GOOGL", "Alphabet Inc.", 2800.00m));
        _stocks.Add(new Stock("AMZN", "Amazon.com Inc.", 3400.00m));
        _stocks.Add(new Stock("MSFT", "Microsoft Corp.", 299.00m));
        _stocks.Add(new Stock("TSLA", "Tesla Inc.", 700.00m));
    }

    public void RegisterTrader(Trader trader)
    {
        _traders.Add(trader);
        trader.TradeExecuted += OnTradeExecuted;
    }

    public void UpdateMarket()
    {
        foreach (var stock in _stocks)
            stock.UpdatePrice();

        var random = new Random();
        foreach (var trader in _traders)
        {
            var stock = _stocks[random.Next(_stocks.Count)];
            int action = random.Next(2);
            int quantity = random.Next(1, 6);

            if (action == 0)
                trader.BuyStock(stock, quantity);
            else
                trader.SellStock(stock, quantity);
        }
    }

    public void PrintMarketStatus()
    {
        Console.WriteLine("\nMarket Status:");
        foreach (var stock in _stocks)
            Console.WriteLine($"  {stock}");

        foreach (var trader in _traders)
            trader.PrintPortfolio();
    }

    private void OnPriceChanged(object sender, PriceChangedEventArgs e)
    {
        var stock = (Stock)sender;
        Console.WriteLine($"[Event] {stock.Ticker} price changed from ${e.OldPrice:F2} to ${e.NewPrice:F2}");
    }

    private void OnTradeExecuted(object sender, TradeEventArgs e)
    {
        Console.WriteLine($"[Trade Event] {e.Trader.Name} {e.Action} {e.Quantity} x {e.Stock.Ticker} at ${e.Price:F2}");
    }
}