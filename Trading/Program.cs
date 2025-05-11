using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Trading.Model;
using Trading.Model.Events;
using Trading.Model.Interfaces;

namespace Trading
{
    class Program
    {
        private static ILogger logger = new ConsoleLogger();

        static async Task Main(string[] args)
        {
            var market = new Market(logger);
            market.SeedStocks();
            market.RegisterTrader(new Trader("Alice", 10000, logger));
            market.RegisterTrader(new Trader("Bob", 15000, logger));

            logger.Log("Starting market simulation...\n");
            await RunSimulationAsync(market, TimeSpan.FromSeconds(2), tickCount: 10);
        }

        static async Task RunSimulationAsync(Market market, TimeSpan interval, int tickCount)
        {
            for (int tick = 1; tick <= tickCount; tick++)
            {
                logger.Log($"\n=== Tick {tick} ===");
                market.UpdateMarket();
                market.PrintMarketStatus();

                await Task.Delay(interval);
            }
            logger.Log("\nSimulation complete.");
        }
    }
}