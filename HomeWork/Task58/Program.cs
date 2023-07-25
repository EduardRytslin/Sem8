// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] array2 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] multipl = Multiplication(array1, array2);

Console.WriteLine("Матрица 1: ");
PrintMatrix(array1);
Console.WriteLine("Матрица 2: ");
PrintMatrix(array2);
Console.WriteLine("Произведение этих двух матриц равно: ");
PrintMatrix(multipl);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] Multiplication (int[,] matrix1, int[,] matrix2)
{
    int[,] MultiplMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int r = 0; r < matrix2.GetLength(0); r++)
            {
            MultiplMatrix[i, j] += matrix1[i, r] * matrix2[r, j];
            }
        }
    }
    return MultiplMatrix;
}