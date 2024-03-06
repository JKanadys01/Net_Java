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
                Console.WriteLine($"Nr: {item.nr} Value: {item.value}, Weight: {item.weight}");
            }
            Console.WriteLine("Total results");
            Result total_resuult = new Result(solution);
            Console.WriteLine($"Total value: {total_resuult.total_value}. Total weight: {total_resuult.total_weight}");
        }
    }
}
