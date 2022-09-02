// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// для работы по убыванию по спирали?
var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
    int c = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arr[c];
                    Console.Write(matrix[j, k] + " ");
                    c++;
                }
                Console.WriteLine();
            }