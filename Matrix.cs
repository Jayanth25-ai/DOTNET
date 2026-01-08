using System;

    class Program
    {
    static void Main(string[] args)
    {
        Console.Write("Enter size of matrix (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        Console.WriteLine("Enter the value of matrix : ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Mat[" + i + "][" + j + "] = ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        Console.WriteLine("The matrix is : ");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mat[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += mat[i, i];
            secondaryDiagonalSum += mat[i, n - i - 1];
        }
        Console.WriteLine("The sum of primary diagonal : " + primaryDiagonalSum);
        Console.WriteLine("The sum of secondary diagonal : " + secondaryDiagonalSum);
        int differentDiagonalSum = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        Console.WriteLine("The difference between two diagonals : "+ differentDiagonalSum);
    }
    
}

