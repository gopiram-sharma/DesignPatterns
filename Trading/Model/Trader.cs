using System;
using System.Collections.Generic;
using Trading.Model.Events;
using Trading.Model.Interfaces;

namespace Trading.Model;

public class Trader
{
    private readonly ILogger _logger;
    public string Name { get; }
    public decimal Cash { get; private set; }
    public Dictionary<Stock, int> Portfolio { get; }

    public event EventHandler<TradeEventArgs> TradeExecuted;

    public Trader(string name, decimal initialCash, ILogger logger)
    {
        _logger = logger;
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

            TradeExecuted?.Invoke(this, new TradeEventArgs(this, stock, quantity, stock.CurrentPrice, "BUY"));
            _logger.Log($"{Name} bought {quantity} shares of {stock.Ticker} at {stock.CurrentPrice:C}");
        }
        else
        {
            _logger.Log($"{Name} tried to buy {quantity} shares of {stock.Ticker} but didn't have enough cash.");
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

            TradeExecuted?.Invoke(this, new TradeEventArgs(this, stock, quantity, stock.CurrentPrice, "SELL"));
            _logger.Log($"{Name} sold {quantity} shares of {stock.Ticker} at {stock.CurrentPrice:C}");
        }
        else
        {
            _logger.Log($"{Name} tried to sell {quantity} shares of {stock.Ticker} but doesn't own enough.");
        }
    }

    public void PrintPortfolio()
    {
        _logger.Log($"\n{Name}'s Portfolio (Cash: ${Cash:F2}):");
        foreach (var kv in Portfolio.Where(kv => kv.Value > 0))
            _logger.Log($"  {kv.Value} of {kv.Key.Ticker} at ${kv.Key.CurrentPrice:F2}");
    }
}