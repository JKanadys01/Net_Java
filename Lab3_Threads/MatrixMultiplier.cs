using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Threads
{
    internal class MatrixMultiplier
    {
        private readonly Matrix matrixA;
        private readonly Matrix matrixB;
        private readonly int MSize;
        private readonly int numThreads;
        public long elapsedTime;
        public int[,] resultMatrix;
        

        public MatrixMultiplier(Matrix matrixA, Matrix matrixB, int numTheads)
        {
            if (matrixA.Size != matrixB.Size)
                throw new ArgumentException("Macierze musza miec ten sam rozmiar");
            this.matrixA = matrixA;
            this.matrixB = matrixB;
            this.MSize = matrixA.Size;
            this.numThreads = numThreads;
        }

        public void MultiplyMatricesSequential()
        {
            int[,] result = new int[MSize, MSize];
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < MSize; i++) 
            {
                for (int j = 0; j < MSize; j++) 
                {
                    for (int k  = 0; k < MSize; k++)
                    {
                        result[i, j] += matrixA.GetValue(i, k) * matrixB.GetValue(k, j);
                    }
                }
            }
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;
            resultMatrix = result;
        }

        public void MultiplyMatricesThreads(int numThreads) 
        {
            int[,] result = new int[MSize, MSize];
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread[] threads = new Thread[numThreads];

            int rowsPerThread = MSize / numThreads;

            for (int t = 0; t < numThreads; t++)
            {
                int startRow = t * rowsPerThread;
                int endRow = (t == numThreads - 1) ? MSize : (t + 1) * rowsPerThread;

                threads[t] = new Thread(() =>
                {
                    for (int i = startRow; i < endRow; i++)
                    {
                        for (int j = 0; j < MSize; j++)
                        {
                            for (int k = 0; k < MSize; k++)
                            {
                                result[i, j] += matrixA.GetValue(i, k) * matrixB.GetValue(k, j);
                            }
                        }
                    }
                });

                threads[t].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;
            resultMatrix = result;
        }

        public void MultiplyMatricesParallel(int numThreads)
        {
            int[,] result = new int[MSize, MSize];
            Stopwatch stopwatch = Stopwatch.StartNew();

            Parallel.For(0, MSize, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, i =>
            {
                for (int j = 0; j < MSize; j++)
                {
                    for (int k = 0; k < MSize; k++)
                    {
                        result[i, j] += matrixA.GetValue(i, k) * matrixB.GetValue(k, j);
                    }
                }
            });

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;
            resultMatrix = result;
        }

        public override string ToString()
        {

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < MSize; i++)
            {
                for (int j = 0; j < MSize; j++)
                {
                    result.Append(resultMatrix[i, j] + "\t");
                }
                result.AppendLine(); 
            }
            return result.ToString();
        }
    }
}
