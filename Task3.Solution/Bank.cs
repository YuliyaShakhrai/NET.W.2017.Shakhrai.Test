using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Bank
    {
        private Stock stock;

        public string Name { get; set; }

        public Bank(string name, Stock observable)
        {
            this.Name = name;
            stock = observable;
        }

        public void BankEventHandler(object info, MarketUpdateEventArgs e)
        {
            Stock temp = (Stock)info;
            StockInfo sInfo = temp.StocksInfo;

            if (sInfo.Euro > 40)
                Console.WriteLine($"{e.Msg} Банк {this.Name} продает евро;  Курс евро: {sInfo.Euro}");
            else
                Console.WriteLine($"{e.Msg} Банк {this.Name} покупает евро;  Курс евро: {sInfo.Euro}");
        }
    }
}
