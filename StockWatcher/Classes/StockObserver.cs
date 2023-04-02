using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockWatcher.Classes
{
    class AppleStockObserver : IObserver<Stock>
    {
        public void Update(Stock data)
        {
            if (data.Name.Equals("APL") && data.Value >= 30)
            {
                Console.WriteLine("Akcje Apple powyżej 30");
            }
        }
    }

    class IbmStockObserver : IObserver<Stock>
    {
        public void Update(Stock data)
        {
            if (data.Name.Equals("IBM") && data.Value >= 20)
            {
                Console.WriteLine("Akcje IBM powyżej 20");
            }
        }
    }
}
