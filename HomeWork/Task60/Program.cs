// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] array3D = CreateMatrix3DRndInt(2, 2, 2, 10, 99);
LinePrint(array3D);

int[,,] CreateMatrix3DRndInt(int rows, int columns, int width, int min, int max)
{
    int[,,] matrix3D = new int[rows, columns, width];
    
    Random rnd = new Random();

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix3D;
}

void LinePrint(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}