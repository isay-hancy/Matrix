using System;

class matrix
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[2, 3];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine("Enter elements for row " + i + ":");

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int n = int.Parse(Console.ReadLine());
                matrix[i, j] = n;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Matrix:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}