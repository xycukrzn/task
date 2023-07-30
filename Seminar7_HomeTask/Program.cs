// //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите количество строк (m):");
// int m = int.Parse(Console.ReadLine()); // Считываем количество строк

// Console.WriteLine("Введите количество столбцов (n):");
// int n = int.Parse(Console.ReadLine()); // Считываем количество столбцов

// double[,] matrix = new double[m, n]; // Создаем двумерный массив размером m×n

// // Создаем объект для генерации случайных чисел
// Random random = new Random();

// // Заполняем массив случайными вещественными числами
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = random.NextDouble(); // Генерируем случайное вещественное число от 0 до 1
//     }
// }

// // Выводим массив на экран
// Console.WriteLine("Двумерный массив:");
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// {
//     // Задаем двумерный массив
//     int[,] array = {
//         { 1, 2, 3 },
//         { 4, 5, 6 },
//         { 7, 8, 9 }
//     };

//     // Выводим массив на экран для наглядности
//     Console.WriteLine("Двумерный массив:");
//     PrintArray(array);

//     // Запрашиваем у пользователя позиции элемента
//     Console.WriteLine("Введите номер строки (от 1 до 3):");
//     int row = int.Parse(Console.ReadLine()) - 1;

//     Console.WriteLine("Введите номер столбца (от 1 до 3):");
//     int col = int.Parse(Console.ReadLine()) - 1;

//     // Проверяем, что введенные позиции находятся в допустимых пределах
//     if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
//     {
//         // Получаем значение элемента по заданным позициям и выводим на экран
//         int value = array[row, col];
//         Console.WriteLine("Значение элемента на позиции [" + (row + 1) + ", " + (col + 1) + "]: " + value);
//     }
//     else
//     {
//         // Выводим сообщение, если позиции находятся вне допустимых пределов
//         Console.WriteLine("Недопустимые позиции элемента. Пожалуйста, введите значения от 1 до 3 для строки и столбца.");
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

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


    {
        // Задаем двумерный массив
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Выводим массив на экран для наглядности
        Console.WriteLine("Двумерный массив:");
        PrintArray(array);

        // Находим среднее арифметическое элементов в каждом столбце
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        double[] columnAverages = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }

            columnAverages[j] = (double)sum / rows;
        }

        // Выводим средние арифметические на экран
        Console.WriteLine("Средние арифметические элементов в каждом столбце:");
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine("Столбец " + (j + 1) + ": " + columnAverages[j]);
        }
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
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

