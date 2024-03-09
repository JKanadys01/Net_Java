using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Knapsack
{
    internal class Result
    {
        public List<Item> total_results;
        public double total_value
        {
            get { return total_results.Sum(item => item.value); }
        }
        public double  total_weight
        {
            get { return total_results.Sum(item => item.weight); }
        }

        public Result(List<Item> items)
        {
            total_results = items;
        }

        public override string ToString()
        {
            string result = "Items in Knapsack\n";
            foreach (var item in total_results)
            {
                result += $"Nr: {item.nr} Value: {item.value}, Weight: {item.weight}\n";
            }
            result += "\nTotal results\n";
            result += $"Total value :{total_value}, Weight: {total_weight}\n";
            return result;
        }

    }
}
