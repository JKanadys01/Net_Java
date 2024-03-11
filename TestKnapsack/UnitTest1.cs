using Lab1_Knapsack;


namespace TestKnapsack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCount()
        {
            List<int> sizes = new List<int>() { 10,20,30,40,50 };
            foreach (int n in sizes) 
            {
                KnapsackProblem problem = new KnapsackProblem(n,10);
                Assert.AreEqual(n, problem.items.Count);
            }
        }

        [TestMethod]
        public void AtleastOne() 
        {
            int nr = 5;
            int seed = 10;
            int capacity = 20;

            KnapsackProblem problem = new KnapsackProblem(nr,seed);
            List<Item> result = problem.Solve(capacity);
            Assert.IsTrue(result.Count >= 1);
        }

        [TestMethod]
        public void NoItem()
        {
            int nr = 5;
            int seed = 10;
            int capacity = 2;

            KnapsackProblem problem = new KnapsackProblem(nr, seed);
            List<Item> result = problem.Solve(capacity);
            Assert.AreEqual(0,result.Count);
        }

        [TestMethod]
        public void ItemOrder() 
        {
            int nr = 5;
            int seed = 10;
            int capacity = 20;

            KnapsackProblem problem1 = new KnapsackProblem(nr,seed);
            KnapsackProblem problem2 = new KnapsackProblem(nr, seed);

            problem2.items.Reverse();
          
            List<Item> result1 = problem1.Solve(capacity);
            List<Item> result2 = problem2.Solve(capacity);

            for (int i = 0; i < result1.Count; i++)
            {
                Assert.AreEqual(result1[i].value, result2[i].value);
                Assert.AreEqual(result1[i].weight, result2[i].weight);
                Assert.AreEqual(result1[i].nr, result2[i].nr);
            }

            Result total_result1 = new Result(result1);
            Result total_result2 = new Result(result2);

            Assert.AreEqual(total_result1.total_weight, total_result2.total_weight);
            Assert.AreEqual(total_result1.total_value, total_result2.total_value);
        }

        [TestMethod]
        public void Example()
        {
            int nr = 5;
            int seed = 10;
            int capacity = 20;

            KnapsackProblem problem = new KnapsackProblem(nr, seed);
            List<Item> expectedResult = new List<Item>
            {
                new Item(8,3,2),
                new Item(10,8,0),
                new Item(8,7,1)
            };
            List<Item> solution = problem.Solve(capacity);
            Assert.AreEqual(expectedResult.Count, solution.Count);

            for (int i = 0; i < expectedResult.Count; i++) 
            {
                Assert.AreEqual(expectedResult[i].value, solution[i].value);
                Assert.AreEqual(expectedResult[i].weight, solution[i].weight);
                Assert.AreEqual(expectedResult[i].nr, solution[i].nr);
            }

            Result total_result = new Result(solution);
            Assert.AreEqual(total_result.total_weight, 18);
            Assert.AreEqual(total_result.total_value, 26);
        }

        [TestMethod]
        public void CheckIfTheSame()
        {
            int nr = 5;
            int seed = 10;
            

            KnapsackProblem problem1 = new KnapsackProblem(nr, seed);
            KnapsackProblem problem2 = new KnapsackProblem(nr, seed);

            List<Item> list1 = problem1.items;
            List<Item> list2 = problem2.items;
            
            Assert.AreEqual(list1.Count, list2.Count);

            for (int i = 0; i < list1.Count; i++)
            {
                Assert.AreEqual(list1[i].value, list2[i].value);
                Assert.AreEqual(list1[i].weight, list2[i].weight);
                Assert.AreEqual(list1[i].nr, list2[i].nr);
            }
        }

        [TestMethod]
        public void NoCapacity()
        {
            int nr = 5;
            int seed = 10;
            int capacity = 0;

            KnapsackProblem problem = new KnapsackProblem(nr, seed);
            List<Item> result = problem.Solve(capacity);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void EmptyProblem()
        {
            int nr = 0;
            int seed = 10;
            int capsacity = 10;

            KnapsackProblem problem = new KnapsackProblem(nr,seed);
            List<Item> solution = problem.Solve(capsacity);
            Assert.AreEqual(0, solution.Count);
        }

        [TestMethod]
        public void NegativeCapacity()
        {
            int nr = 5;
            int seed = 10;
            int capsacity = -20;

            KnapsackProblem problem = new KnapsackProblem(nr, seed);
            List<Item> solution = problem.Solve(capsacity);
            Assert.AreEqual(0, solution.Count);
        }
    }
}