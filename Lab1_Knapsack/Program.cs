namespace Lab1_Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int nr_of_items = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed:");
            int seed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the capacity of the knapsack:");
            int capacity = int.Parse(Console.ReadLine());

            KnapsackProblem problem = new KnapsackProblem(nr_of_items, seed);
            Console.WriteLine("Knapsack items:");
            Console.WriteLine(problem.ToString());

            List<Item> solution = problem.Solve(capacity);
            Console.WriteLine("Items in the knapsack:");
            foreach (var item in solution) 
            {
                Console.WriteLine($"Value: {item.value}, Weight: {item.weight}");
            }
        }
    }
}
