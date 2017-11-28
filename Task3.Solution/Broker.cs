using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Broker
    {
        private Stock _stock;

        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            _stock = stock;
        }

        public void BrokerEventHandler(object info, MarketUpdateEventArgs e)
        {
            Stock temp = (Stock)info;
            StockInfo sInfo = temp.StocksInfo;

            if (sInfo.USD > 30)
                Console.WriteLine($"{e.Msg}Брокер {this.Name} продает доллары;  Курс доллара: {sInfo.USD}");
            else
                Console.WriteLine($"{e.Msg}Брокер {this.Name} покупает доллары;  Курс доллара: {sInfo.USD}");
        }
    }
}
