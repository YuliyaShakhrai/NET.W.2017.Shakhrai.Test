using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3
{
    public class Stock
    {
        private StockInfo stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public StockInfo StocksInfo
        {
            get
            {
                return stocksInfo;
            }
            set
            {
                stocksInfo = value;
            }
        }

        public void Market(string msg)
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnMarketUpdate(new MarketUpdateEventArgs() { Msg = msg });
        }

        public event EventHandler<MarketUpdateEventArgs> MarketUpdate = delegate { };

        public void OnMarketUpdate(MarketUpdateEventArgs eventArgs)
        {
            EventHandler<MarketUpdateEventArgs> temp = MarketUpdate;
            temp?.Invoke(this, eventArgs);
        }

    }
}
