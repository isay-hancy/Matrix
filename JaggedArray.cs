using System;

class JaggedArrayProgram
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[3][];

        jagged[0] = new int[3];
        jagged[1] = new int[2];
        jagged[2] = new int[4];

        for (int i = 0; i < jagged.Length; i++)
        {
            Console.WriteLine("Enter elements for row " + i);

            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged Array:");

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}