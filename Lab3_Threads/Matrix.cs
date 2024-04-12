using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Threads
{
    internal class Matrix
    {
        private readonly int size;
        private readonly int[,] matrix;
        private readonly Random rand;

        public int Size => size;

        
        public Matrix(int size, int seed)
        {
            this.size = size;
            matrix = new int[size,size];
            rand = new Random(seed);
            GenerateRandomMatrix();
        }

        private void GenerateRandomMatrix()
        {  
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
        }

        public int GetValue(int row, int column)
        {
            if (row < 0 || row >= size || column < 0 || column >= size)
                throw new ArgumentOutOfRangeException("Niewłaściwi indeks kolumn lub wierszy");
            return matrix[row, column];        
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0;i < size; i++) 
            {
                for(int j = 0;j < size; j++)
                {
                    result += matrix[i, j] + "\t";
                }
                result += "\r\n";
            }
            return result;
        }
    }
}
