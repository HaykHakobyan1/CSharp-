/*using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 8; 
        int[] queens = new int[n]; 

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            queens[i] = rand.Next(0, n);
        }

        
        while (!IsSolutionValid(queens))
        {
           
            for (int i = 0; i < n; i++)
            {
                queens[i] = rand.Next(0, n);
            }
        }

        
        DisplayBoard(queens);
    }

    
    static bool IsSolutionValid(int[] queens)
    {
        for (int i = 0; i < queens.Length; i++)
        {
            for (int j = i + 1; j < queens.Length; j++)
            {
                if (queens[i] == queens[j] || Math.Abs(queens[i] - queens[j]) == Math.Abs(i - j))
                {
                    return false;
                }
            }
        }
        return true; 
    }

    
    static void DisplayBoard(int[] queens)
    {
        int n = queens.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (queens[i] == j)
                {
                    Console.Write("Q ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }
    }
}
*/