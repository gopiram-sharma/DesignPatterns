using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Trading.Model;
using Trading.Model.Events;

namespace Trading
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var market = new Market();
            market.SeedStocks();
            market.RegisterTrader(new Trader("Alice", 10000));
            market.RegisterTrader(new Trader("Bob", 15000));

            Console.WriteLine("Starting market simulation...\n");
            await RunSimulationAsync(market, TimeSpan.FromSeconds(2), tickCount: 10);
        }

        static async Task RunSimulationAsync(Market market, TimeSpan interval, int tickCount)
        {
            for (int tick = 1; tick <= tickCount; tick++)
            {
                Console.WriteLine($"\n=== Tick {tick} ===");
                market.UpdateMarket();
                market.PrintMarketStatus();

                await Task.Delay(interval);
            }
            Console.WriteLine("\nSimulation complete.");
        }
    }
}