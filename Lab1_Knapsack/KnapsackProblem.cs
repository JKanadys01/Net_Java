using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestKnapsack")]
namespace Lab1_Knapsack
{
    internal class KnapsackProblem
    {
        public List<Item> items;

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
            string result = "Sorted items\n";
            foreach (var item in items) 
            {
                result += $"Nr: {item.nr} Value: {item.value}, Weight: {item.weight}\n";
            }
            return result;
        }
       
    }
}
