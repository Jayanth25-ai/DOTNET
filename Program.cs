using System;

namespace SnakePatternMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Snake Pattern of a Matrix ===");

            // give the size of matrix
            Console.Write("Enter size of matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            // Declaring the 2D array
            int[,] mat = new int[n, n];

            // Give the values for matrix
            Console.WriteLine("Enter the matrix elements fot the matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("mat[" + i + "][" + j + "] = ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Optional: display the matrix normally
            Console.WriteLine();
            Console.WriteLine("Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Print snake pattern
            Console.WriteLine();
            Console.WriteLine("Snake pattern output:");

            for (int i = 0; i < n; i++)
            {
                // Even row index: left to right
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
                // Odd row index: right to left
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
