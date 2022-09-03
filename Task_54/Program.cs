// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int row, int col, int min, int max)

{
    int[,] matrix = new int[row, col];
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

// Console.WriteLine("");

void PrintMatrixReverse(int[,] matrix)
{
    //int maxIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int a = 0; a < matrix.GetLength(1) - 1; a++)
            {
                if (matrix[i, a] < matrix[i, a + 1])
                {
                    int newMatrix = matrix[i, a + 1];
                    matrix[i, a + 1] = matrix[i, a];
                    matrix[i, a] = newMatrix;
                    a++;
                }
            }
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] Array2D = CreateMatrixRndInt(3, 4, 1,20);
PrintMatrix(Array2D);
Console.WriteLine("");
PrintMatrixReverse(Array2D);
