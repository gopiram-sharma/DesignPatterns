namespace Trading.Model.Events;
using System;

public class TradeEventArgs : EventArgs
    {
        public Trader Trader { get; }
        public Stock Stock { get; }
        public int Quantity { get; }
        public decimal Price { get; }
        public string Action { get; }

        public TradeEventArgs(Trader trader, Stock stock, int quantity, decimal price, string action)
        {
            Trader = trader;
            Stock = stock;
            Quantity = quantity;
            Price = price;
            Action = action;
        }
    }