/*

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


*/


int[,] InitMatrix(int a, int b)
{
    int[,] matrix = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}




void SumTambelMatrix(int[,] matrix)
{



    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        double sumTable = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            sumTable += matrix[j, i];

        }

        Console.WriteLine($"Сумма элементов {i + 1} столба = {sumTable / 2}");

    }


}






int a = 4;
int b = 4;

int[,] matrix = InitMatrix(a, b);
PrintMatrix(matrix);
SumTambelMatrix(matrix);
