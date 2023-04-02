using StockWatcher.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockWatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var observableStock = new Observable<Stock>();

            // obserwator dla IBM
            IbmStockObserver ibmStockObserver = new IbmStockObserver();
            observableStock.Subscribe(ibmStockObserver);

            // obserwator dla Apple
            AppleStockObserver appleStockObserver = new AppleStockObserver();
            observableStock.Subscribe(appleStockObserver);

            StockDummySimulator simulator = new StockDummySimulator();
            foreach (var item in simulator)
            {
                Console.WriteLine($"Generator danych: {item.Name} - {item.Value}");
                observableStock.Subject = item;
            }
            Console.ReadKey();

        }
    }
}
