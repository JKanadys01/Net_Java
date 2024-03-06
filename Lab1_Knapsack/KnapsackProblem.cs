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
            Random random = new Random(seed);
            for (int i = 0; i < nr_of_items; i++)
            {
                int Value = random.Next(1,11);
                int Weight = random.Next(1, 11);
                items.Add(new Item(Value, Weight, i));
            }
        }
        public List<Item> Solve(int capacity)
        {
            items = items.OrderByDescending(item => (double)item.value / item.weight).ToList();
            
            List <Item> result = new List<Item>();
            int currentWeight = 0;
            int currentValue = 0;
            Console.WriteLine("Sorted items:");
            foreach (var item in items)
            {
                Console.WriteLine($"Nr: {item.nr} Value: {item.value}, Weight: {item.weight}");
                if (currentWeight + item.weight <= capacity) 
                {
                    result.Add(item);
                    currentWeight += item.weight;
                    currentValue += item.value;
                }
            }
            Console.WriteLine("\n");
            return result;
            
        } 
        public override string ToString()
        {
            string result = "";
            foreach (var item in items) 
            {
                result += $"Nr: {item.nr} Value: {item.value}, Weight: {item.weight}\n";
            }
            return result;
        }
       
    }
}
