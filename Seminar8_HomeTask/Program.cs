//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        // Упорядочиваем по убыванию элементы каждой строки
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Array.Sort(array, i * array.GetLength(1), array.GetLength(1), new ReverseComparer());
        }

        // Выводим массив на экран
        Console.WriteLine("Упорядоченный двумерный массив:");
        PrintArray(array);
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

    // Вспомогательный класс для сравнения элементов по убыванию
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }