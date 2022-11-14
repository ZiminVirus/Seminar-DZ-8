// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumElemStringArray(int[,] matrix)
{
    int sum = default;
    int temp = default;
    int rowSmallSumElem = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j]; //считаю сумму элементов в строке

        }

        if (i == 0) temp = sum; 
        else if (sum < temp)
        {
            temp = sum;
            rowSmallSumElem = i;
        }
     }
    return rowSmallSumElem;
}




int[,] array2D = CreateMatrixRndInt(3, 2, 0, 100);
PrintMatrix(array2D);
Console.WriteLine();
int sumElemStringArray = SumElemStringArray(array2D);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {sumElemStringArray + 1} строка. (нумерация строк начинается с 1)");
