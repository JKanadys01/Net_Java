using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Knapsack
{
    internal class Item
    {
        public int value { get; }
        public int weight { get; }

        public Item(int Value, int Weight)
        {
            value = Value;
            weight = Weight;
        }
    }
}
