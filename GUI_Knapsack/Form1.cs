using Lab1_Knapsack;

namespace GUI_Knapsack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Nr = int.Parse(nr_of_items.Text);
            int Seed = int.Parse(seed.Text);
            int Capacity = int.Parse(capacity.Text);

            KnapsackProblem problem = new KnapsackProblem(Nr, Seed);
            problem_list.Items.Clear();
            foreach (string line in problem.ToString().Split('\n'))
            {
                problem_list.Items.Add(line);
            }
            List<Item> solution = problem.Solve(Capacity);

            Result result = new Result(solution);

            sorted_list.Items.Clear();
            foreach (string line in problem.ToString().Split('\n'))
            {
                sorted_list.Items.Add(line);
            }
            knapsac_list.Items.Clear();
            foreach (string line in result.ToString().Split('\n'))
            {
                knapsac_list.Items.Add(line);
            }
        }

        private void nr_of_items_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nr_of_items.Text) && !int.TryParse(nr_of_items.Text, out _))
            {
                nr_of_items.BackColor = Color.Red;
            }
            else
            {
                nr_of_items.BackColor = SystemColors.Window;
            }
        }

        private void capacity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(capacity.Text) && !int.TryParse(capacity.Text, out _))
            {
                capacity.BackColor = Color.Red;
            }
            else
            {
                capacity.BackColor = SystemColors.Window;
            }
        }

        private void seed_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(seed.Text) && !int.TryParse(seed.Text, out _))
            {
                seed.BackColor = Color.Red;
            }
            else
            {
                seed.BackColor = SystemColors.Window;
            }
        }
    }
}
