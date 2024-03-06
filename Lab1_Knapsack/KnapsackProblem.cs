using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Knapsack
{
    internal class KnapsackProblem
    {
        private List<Item> items;

        public KnapsackProblem(int nr_of_items, int seed)
        {
            items = new List<Item>();
            Random random = new Random();
            for (int i = 0; i < nr_of_items; i++)
            {
                int Value = random.Next(1,11);
                int Weight = random.Next(1, 11);
                items.Add(new Item(Value, Weight));
            }
        }
        public List<Item> Solve(int capacity)
        {
            items = items.OrderByDescending(item => (double)item.value / item.weight).ToList();

            List<Item> result = new List<Item>();
            int currentWeight = 0;
            foreach (var item in items)
            {
                if (currentWeight + item.weight <= capacity) 
                {
                    result.Add(item);
                    currentWeight += item.weight;
                }
            }
            return result;
            
        }
        public override string ToString()
        {
            string result = "";
            foreach (var item in items) 
            {
                result += $"Value: {item.value}, Weight: {item.weight}\n";
            }
            return result;
        }
    }
}
