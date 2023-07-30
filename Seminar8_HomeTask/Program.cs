// //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    
// {
//     int[,] array = {
//         { 1, 4, 7, 2 },
//         { 5, 9, 2, 3 },
//         { 8, 4, 2, 4 }
//     };

//     // Упорядочиваем по убыванию элементы каждой строки
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         SortRowDescending(array, i);
//     }

//     // Выводим массив на экран
//     Console.WriteLine("Упорядоченный двумерный массив:");
//     PrintArray(array);
// }

// // Метод для сортировки строки по убыванию
// static void SortRowDescending(int[,] arr, int rowIndex)
// {
//     int rowLength = arr.GetLength(1);
//     int[] row = new int[rowLength];

//     // Копируем элементы строки в одномерный массив
//     for (int j = 0; j < rowLength; j++)
//     {
//         row[j] = arr[rowIndex, j];
//     }

//     // Сортируем одномерный массив по убыванию
//     Array.Sort(row, (x, y) => y.CompareTo(x));

//     // Копируем отсортированные элементы обратно в исходную строку
//     for (int j = 0; j < rowLength; j++)
//     {
//         arr[rowIndex, j] = row[j];
//     }
// }

// // Вспомогательный метод для вывода двумерного массива на экран
// static void PrintArray(int[,] arr)
// {
//     int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// {
//     int[,] array = {
//         { 1, 4, 7, 2 },
//         { 5, 9, 2, 3 },
//         { 8, 4, 2, 4 },
//         { 5, 2, 6, 7 }
//     };

//     int minRowSum = int.MaxValue;
//     int minRowIdx = -1;

//     // Находим строку с наименьшей суммой элементов
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int rowSum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             rowSum += array[i, j];
//         }

//         if (rowSum < minRowSum)
//         {
//             minRowSum = rowSum;
//             minRowIdx = i;
//         }
//     }

//     // Выводим номер строки с наименьшей суммой элементов
//     Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minRowIdx + 1));
// }

// //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// {
//     int[,] matrix1 = {
//         { 2, 4 },
//         { 3, 2 }
//     };

//     int[,] matrix2 = {
//         { 3, 4 },
//         { 3, 3 }
//     };

//     int rows1 = matrix1.GetLength(0);
//     int cols1 = matrix1.GetLength(1);
//     int rows2 = matrix2.GetLength(0);
//     int cols2 = matrix2.GetLength(1);

//     if (cols1 != rows2)
//     {
//         Console.WriteLine("Умножение матриц невозможно, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//         return;
//     }

//     int[,] resultMatrix = new int[rows1, cols2];

//     // Вычисление произведения матриц
//     for (int i = 0; i < rows1; i++)
//     {
//         for (int j = 0; j < cols2; j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < cols1; k++)
//             {
//                 sum += matrix1[i, k] * matrix2[k, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }

//     // Вывод результирующей матрицы
//     Console.WriteLine("Результирующая матрица:");
//     PrintArray(resultMatrix);
// }

//     // Вспомогательный метод для вывода двумерного массива на экран
// static void PrintArray(int[,] arr)
// {
//     int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// {
//     int[,,] array = {
//         { { 66, 25 }, { 34, 41 } },
//         { { 27, 90 }, { 26, 55 } }
//     };

//     // Выводим трехмерный массив на экран
//     Console.WriteLine("Трехмерный массив:");
//     PrintArray(array);
// }

// // Вспомогательный метод для вывода трехмерного массива на экран
// static void PrintArray(int[,,] arr)
// {
//     int depth = arr.GetLength(0);
//     int rows = arr.GetLength(1);
//     int cols = arr.GetLength(2);

//     for (int k = 0; k < depth; k++)
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(arr[k, i, j] + "(" + k + "," + i + "," + j + ") ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

{
    int n = 4;
    int[,] spiralArray = new int[n, n];

    int number = 1;
    int top = 0;
    int bottom = n - 1;
    int left = 0;
    int right = n - 1;

    while (number <= n * n)
    {
        // Верхняя строка
        for (int i = left; i <= right; i++)
            spiralArray[top, i] = number++;
        top++;

        // Правый столбец
        for (int i = top; i <= bottom; i++)
            spiralArray[i, right] = number++;
        right--;

        // Нижняя строка
        for (int i = right; i >= left; i--)
            spiralArray[bottom, i] = number++;
        bottom--;

        // Левый столбец
        for (int i = bottom; i >= top; i--)
            spiralArray[i, left] = number++;
        left++;
    }

    // Выводим спиральный массив на экран
    Console.WriteLine("Спиральный массив:");
    PrintArray(spiralArray);
}

// Вспомогательный метод для вывода двумерного массива на экран
static void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(arr[i, j].ToString().PadLeft(2, '0') + " ");
        }
        Console.WriteLine();
    }
}
