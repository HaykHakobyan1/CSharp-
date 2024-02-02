/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        // Input matrix elements
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Enter elements for row {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        FindSaddlePoint(matrix);
    }

    static void FindSaddlePoint(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int maxInRow = matrix[i, 0];
            int colIndex = 0;

            // Find maximum element in current row
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j];
                    colIndex = j;
                }
            }

            // Check if maxInRow is minimum in its column
            bool isSaddlePoint = true;
            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, colIndex] < maxInRow)
                {
                    isSaddlePoint = false;
                    break;
                }
            }

            // If maxInRow is minimum in its column, it is a saddle point
            if (isSaddlePoint)
            {
                Console.WriteLine($"Saddle point value: {maxInRow}");
                return;
            }
        }

        // If no saddle point is found
        Console.WriteLine("no");
    }
}
*/