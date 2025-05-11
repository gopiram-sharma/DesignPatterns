namespace Trading.Model;
using System;
using System.Collections.Generic;
using Trading.Model.Events;

public class Trader
{
    public string Name { get; }
    public decimal Cash { get; private set; }
    public Dictionary<Stock, int> Portfolio { get; }

    public event EventHandler<TradeEventArgs> TradeExecuted;

    public Trader(string name, decimal initialCash)
    {
        Name = name;
        Cash = initialCash;
        Portfolio = new Dictionary<Stock, int>();
    }

    public void BuyStock(Stock stock, int quantity)
    {
        decimal cost = stock.CurrentPrice * quantity;
        if (Cash >= cost)
        {
            Cash -= cost;
            if (Portfolio.ContainsKey(stock))
                Portfolio[stock] += quantity;
            else
                Portfolio[stock] = quantity;

            Console.WriteLine($"{Name} bought {quantity} of {stock.Ticker} at ${stock.CurrentPrice:F2}");
            TradeExecuted?.Invoke(this, new TradeEventArgs(this, stock, quantity, stock.CurrentPrice, "BUY"));

        }
    }

    public void SellStock(Stock stock, int quantity)
    {
        if (Portfolio.ContainsKey(stock) && Portfolio[stock] >= quantity)
        {
            decimal revenue = stock.CurrentPrice * quantity;
            Cash += revenue;
            Portfolio[stock] -= quantity;
            if (Portfolio[stock] == 0)
                Portfolio.Remove(stock);

            Console.WriteLine($"{Name} sold {quantity} of {stock.Ticker} at ${stock.CurrentPrice:F2}");
            TradeExecuted?.Invoke(this, new TradeEventArgs(this, stock, quantity, stock.CurrentPrice, "SELL"));
        }
        else
        {
            Console.WriteLine($"{Name} doesn't have {quantity} of {stock.Ticker} to sell");
        }
    }

    public void PrintPortfolio()
    {
        Console.WriteLine($"\n{Name}'s Portfolio (Cash: ${Cash:F2}):");
        foreach (var kv in Portfolio.Where(kv => kv.Value > 0))
            Console.WriteLine($"  {kv.Value} of {kv.Key.Ticker} at ${kv.Key.CurrentPrice:F2}");
    }
}