/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9


*/
int m = 3;
int n = 4;



double[,] InitMatrix(int m, int n)
{
    double b = 0;
    double[,] matrix = new double[m, n];
    Random randomizer = new Random();
    double a = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a = randomizer.NextDouble() * randomizer.Next(-10, 10);
            b = Math.Round(a, 1);
            matrix[i, j] = b;

        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Console.Write("{0,6:F1}", matrix[i, j]);
            Console.Write($"{matrix[i, j]}     ");
        }
        Console.WriteLine();
    }
}


double[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);