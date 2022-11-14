// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] DivArray(int[,] array1, int[,] array2)
{
    
    var array3 = new int[array1.GetLength(0), array2.GetLength(1)];
   if (array1.GetLength(0) == array2.GetLength(0) && array1.GetLength(1) == array2.GetLength(1))
    {
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    array3[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }

    }
    else System.Console.WriteLine("Произведение 2-х матриц невозможно");
    return (array3);

}


System.Console.WriteLine("Первая матрица");
int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrix1);
System.Console.WriteLine("Вторая матрица");
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrix2);
System.Console.WriteLine("Произведение первой и второй матриц");
int[,] matrix3 = DivArray(matrix1, matrix2);
PrintMatrix(matrix3);