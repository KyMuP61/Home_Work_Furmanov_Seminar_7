/*

Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет
*/


int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CountMatrix(int[,] matrix)
{

    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            count++;

        }
    }
    return count;
}



void FindeIndexMatrix(int[,] matrix, int indexMatrix)
{


    int resultCount = 1;
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (count == indexMatrix)
            {
                resultCount = count;
                Console.WriteLine($"Элменетом на позийии -{count}- является число {matrix[i, j]}");
                count++;

            }
            else
            {
                count++;
            }

        }
    }



    if (resultCount != indexMatrix)
    {
        Console.WriteLine($"Такого элемента ({indexMatrix}) - нет");
    }


}


int m = 4;
int n = 4;

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"колличество элементов массива = {CountMatrix(matrix)}");
Console.WriteLine();
Console.WriteLine("Введите позицию искомого элемента: ");
int initIndex = int.Parse(Console.ReadLine());

FindeIndexMatrix(matrix, initIndex);

