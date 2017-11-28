using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3.Console
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            var bank = new Bank("MeowBank", stock);
            var broker = new Broker("Meowker", stock);

            stock.MarketUpdate += bank.BankEventHandler;
            stock.MarketUpdate += broker.BrokerEventHandler;

            stock.Market("Change!\n");
            Thread.Sleep(1000);
            stock.Market("Change!\n");
            Thread.Sleep(1000);
            stock.Market("Change!\n");
            Thread.Sleep(1000);
            stock.Market("Change!\n");

            Console.ReadLine();
        }
    }
}
