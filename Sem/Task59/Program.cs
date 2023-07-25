// Задача 59: Задайте двумерный массив из целых чисел.        |  Например, задан массив: |  Наименьший элемент — 1, на выходе получим след. массив:
// Напишите программу, которая удалит строку и столбец, на    |  1 4 7 2                 |  9 2 3
// пересечении которых расположен наименьший элемент массива. |  5 9 2 3                 |  4 2 4
//                                                            |  8 4 2 4                 |  2 6 7
//                                                            |  5 2 6 7                 |

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 3 x 4
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int[] MinElemIndex(int[,] matrix)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] <= matrix[row,column]) //Если <= — это последнее вхождение
            {
                row = i;
                column= j;
            }
        }
    }
    return new int[]{row,column};
}

int[,] DeleteRowColumnMinElem(int[,] matrix, int delRow, int delColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == delRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == delColumn) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

int[] minElemIndex = MinElemIndex(array2d);