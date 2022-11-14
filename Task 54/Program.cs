// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //Создали массив заполненный случайными числами
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //Вывод массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void SortMatrixArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                
                    int temp = matrix[i, j];
                    if (temp > matrix[i, k])
                    {
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;

                    }
                    else continue;
            }
        }
    }
}




int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
SortMatrixArray(array2D);
PrintMatrix(array2D);

