using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int target = 5;
        bool found = false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == target)
                {
                    found = true;
                    Console.WriteLine($"Found {target} at position ({i}, {j})");
                    goto ExitLoops; 
                }
            }
        }

    ExitLoops:
        if (!found)
        {
            Console.WriteLine($"{target} not found in matrix.");
        }
    }
}
