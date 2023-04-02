﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockWatcher.Classes
{
    class StockDummySimulator : IEnumerable<Stock>
    {
        private Random rnd = new Random();
        private string[] names = { "APL", "IBM", "GOG" };

        public IEnumerator<Stock> GetEnumerator()
        {
            Console.WriteLine("start iterator");
            for (int i = 0; i < 15; i++)
            {
                string ticker = names[rnd.Next(0, names.Length)];
                double val = rnd.Next(1, 101) + rnd.NextDouble();
                yield return new Stock() { Name=ticker, Value=val  };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
