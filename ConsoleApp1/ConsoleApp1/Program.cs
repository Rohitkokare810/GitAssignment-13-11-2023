using System;

class Program
{
    static void Main()
    {
        // Initialize jagged array with student scores
        int[][] studentScores = new int[][]
        {
            new int[] {85, 92, 78},
            new int[] {90, 87, 93, 89},
            new int[] {76, 88}
        };

        // Calculate and print average score for all students combined
        double totalAverage = CalculateAverage(studentScores);
        Console.WriteLine($"Average score for all students combined: {totalAverage:F2}");

        // Calculate and print average score for each student
        for (int i = 0; i < studentScores.Length; i++)
        {
            double studentAverage = CalculateAverage(studentScores[i]);
            Console.WriteLine($"Average score for Student {i + 1}: {studentAverage:F2}");
        }

        // Print scores of each student using nested loops
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write($"Student {i + 1} Scores: ");
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write($"{studentScores[i][j]} ");
            }
            Console.WriteLine();
        }
    }

    // Function to calculate average of an array of integers
    static double CalculateAverage(int[] scores)
    {
        if (scores.Length == 0)
        {
            return 0; // Avoid division by zero
        }

        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }

        return (double)sum / scores.Length;
    }

    // Function to calculate average of a jagged array of integers
    static double CalculateAverage(int[][] scores)
    {
        if (scores.Length == 0)
        {
            return 0; // Avoid division by zero
        }

        int totalSum = 0;
        int totalLength = 0;

        foreach (int[] studentScores in scores)
        {
            foreach (int score in studentScores)
            {
                totalSum += score;
                totalLength++;
            }
        }

        return (double)totalSum / totalLength;
        
    }
}
