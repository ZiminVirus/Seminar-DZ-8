// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет 
// построчно выводить массив, 
// добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max) 
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j, k] = CheckingUniquenessArrayElement(matrix, min, max, i, j, k);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) { Console.Write($"{matrix[i, j, k],5}({i},{j},{k})"); }
        }
    }
}

Random rnd = new Random();
int CheckingUniquenessArrayElement(int[,,] matrix, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool stop = false;
        value = rnd.Next(min, max + 1);
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            if (stop) { break; }
            for (int m = 0; m < matrix.GetLength(1); m++)
            {
                if (stop) { break; }
                for (int n = 0; n < matrix.GetLength(2); n++)
                {
                    if (matrix[l, m, n] == value) { stop = true; break; }
                    if (l == i && m == j && n == k) { exist = false; }
                }
            }
        }
    }
    return value;
}  


int[,,] matrix1 = CreateMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(matrix1);