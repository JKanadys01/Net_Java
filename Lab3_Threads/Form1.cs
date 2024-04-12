namespace Lab3_Threads
{
    public partial class Form1 : Form
    {
        private Matrix AResult;
        private Matrix BResult;
        private MatrixMultiplier sequentialResult;
        private MatrixMultiplier threadsResult;
        private MatrixMultiplier parallelResult;
        private long sequentialTime;
        private long threadsTime;
        private long parallelTime;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            generated_textBox.Clear();
            seq_textBox.Clear();
            thread_textBox.Clear();
            parallel_textBox.Clear();

            int matrixSize, numThreads, seed;
            if (!int.TryParse(size_textBox.Text, out matrixSize) || matrixSize <= 0)
            {
                MessageBox.Show("Please enter a valid matrix size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(num_thread_textBox.Text, out numThreads) || numThreads <= 0)
            {
                MessageBox.Show("Please enter a valid number of threads.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(seed_textBox.Text, out seed))
            {
                MessageBox.Show("Please enter a valid seed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            matrixSize = Convert.ToInt32(size_textBox.Text);
            numThreads = Convert.ToInt32(num_thread_textBox.Text);
            seed = Convert.ToInt32(seed_textBox.Text);
            Matrix matrixA = new Matrix(matrixSize, seed);
            Matrix matrixB = new Matrix(matrixSize, seed + 1);
            AResult = matrixA;
            BResult = matrixB;
            MatrixMultiplier multiplier = new MatrixMultiplier(matrixA, matrixB, numThreads);

            multiplier.MultiplyMatricesSequential();
            sequentialTime = multiplier.elapsedTime;
            sequentialResult = multiplier;

            multiplier.MultiplyMatricesThreads(numThreads);
            threadsTime = multiplier.elapsedTime;
            threadsResult = multiplier;
            generated_textBox.Text += $"Threads (Used {multiplier.UsedThreads} threads):"; // Dodanie wyœwietlania liczby u¿ytych w¹tków
            multiplier.MultiplyMatricesParallel(numThreads);
            parallelTime = multiplier.elapsedTime;
            parallelResult = multiplier;
            
            generated_textBox.Text += $"Parallel (Used {multiplier.UsedThreads} threads):"; // Dodanie wyœwietlania liczby u¿ytych w¹tków
            seq_textBox.Text = $"{sequentialTime} ms\r\n";
            thread_textBox.Text += $"{threadsTime} ms\r\n";
            parallel_textBox.Text += $"{parallelTime} ms\r\n";

        }

        private void sequential_button_Click(object sender, EventArgs e)
        {
            seq_textBox.Clear();
            int matrixSize, numThreads, seed;
            if (!int.TryParse(size_textBox.Text, out matrixSize) || matrixSize <= 0)
            {
                MessageBox.Show("Please enter a valid matrix size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(num_thread_textBox.Text, out numThreads) || numThreads <= 0)
            {
                MessageBox.Show("Please enter a valid number of threads.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(seed_textBox.Text, out seed))
            {
                MessageBox.Show("Please enter a valid seed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            matrixSize = Convert.ToInt32(size_textBox.Text);
            numThreads = Convert.ToInt32(num_thread_textBox.Text);
            seed = Convert.ToInt32(seed_textBox.Text);
            Matrix matrixA = new Matrix(matrixSize, seed);
            Matrix matrixB = new Matrix(matrixSize, seed + 1);
            AResult = matrixA;
            BResult = matrixB;
            MatrixMultiplier multiplier = new MatrixMultiplier(matrixA, matrixB, numThreads);

            multiplier.MultiplyMatricesSequential();
            sequentialTime = multiplier.elapsedTime;
            sequentialResult = multiplier;
            seq_textBox.Text = $"{sequentialTime} ms\r\n";
        }

        private void threads_button_Click(object sender, EventArgs e)
        {
            thread_textBox.Clear();
            int matrixSize, numThreads, seed;
            if (!int.TryParse(size_textBox.Text, out matrixSize) || matrixSize <= 0)
            {
                MessageBox.Show("Please enter a valid matrix size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(num_thread_textBox.Text, out numThreads) || numThreads <= 0)
            {
                MessageBox.Show("Please enter a valid number of threads.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(seed_textBox.Text, out seed))
            {
                MessageBox.Show("Please enter a valid seed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            matrixSize = Convert.ToInt32(size_textBox.Text);
            numThreads = Convert.ToInt32(num_thread_textBox.Text);
            seed = Convert.ToInt32(seed_textBox.Text);
            Matrix matrixA = new Matrix(matrixSize, seed);
            Matrix matrixB = new Matrix(matrixSize, seed + 1);
            AResult = matrixA;
            BResult = matrixB;
            MatrixMultiplier multiplier = new MatrixMultiplier(matrixA, matrixB, numThreads);
            multiplier.MultiplyMatricesThreads(numThreads);
            threadsTime = multiplier.elapsedTime;
            threadsResult = multiplier;
            thread_textBox.Text += $"{threadsTime} ms\r\n";
        }

        private void paralell_button_Click(object sender, EventArgs e)
        {
            parallel_textBox.Clear();
            int matrixSize, numThreads, seed;
            if (!int.TryParse(size_textBox.Text, out matrixSize) || matrixSize <= 0)
            {
                MessageBox.Show("Please enter a valid matrix size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(num_thread_textBox.Text, out numThreads) || numThreads <= 0)
            {
                MessageBox.Show("Please enter a valid number of threads.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(seed_textBox.Text, out seed))
            {
                MessageBox.Show("Please enter a valid seed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            matrixSize = Convert.ToInt32(size_textBox.Text);
            numThreads = Convert.ToInt32(num_thread_textBox.Text);
            seed = Convert.ToInt32(seed_textBox.Text);
            Matrix matrixA = new Matrix(matrixSize, seed);
            Matrix matrixB = new Matrix(matrixSize, seed + 1);
            AResult = matrixA;
            BResult = matrixB;
            MatrixMultiplier multiplier = new MatrixMultiplier(matrixA, matrixB, numThreads);
            multiplier.MultiplyMatricesParallel(numThreads);
            parallelTime = multiplier.elapsedTime;
            parallelResult = multiplier;
            parallel_textBox.Text += $"{parallelTime} ms\r\n";
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            generated_textBox.Text = $"Matrix A:\r\n{AResult}\r\n";
            generated_textBox.Text += $"Matrix B:\r\n{BResult}\r\n";
            generated_textBox.Text += $"Sequential:\r\n{sequentialResult}\r\n";
            generated_textBox.Text += $"Threads:\r\n{threadsResult}\r\n";
            generated_textBox.Text += $"Parallel:\r\n{parallelResult}\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 displayForm = new Form2();
            displayForm.ShowDialog();
        }

        
    }
}
