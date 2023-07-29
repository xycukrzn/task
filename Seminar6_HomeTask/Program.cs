//  //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 
//  Console.WriteLine("Введите количество чисел (M):");
// int M = int.Parse(Console.ReadLine()); // Считываем количество чисел

// int countGreaterZero = 0; // Инициализируем счетчик чисел больше 0

// // Вводим M чисел и считаем, сколько из них больше 0
// for (int i = 0; i < M; i++)
// {
//     Console.WriteLine("Введите число " + (i + 1) + ":");
//     int number = int.Parse(Console.ReadLine());

//     if (number > 0)
//     {
//         countGreaterZero++;
//     }
// }

// // Выводим результат на экран
// Console.WriteLine("Количество чисел больше 0: " + countGreaterZero);


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1:");
double k1 = double.Parse(Console.ReadLine()); // Считываем значение k1

Console.WriteLine("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine()); // Считываем значение b1

Console.WriteLine("Введите значение k2:");
double k2 = double.Parse(Console.ReadLine()); // Считываем значение k2

Console.WriteLine("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine()); // Считываем значение b2

// Находим x-координату точки пересечения
double x = (b2 - b1) / (k1 - k2);

// Находим y-координату точки пересечения
double y = k1 * x + b1;

// Выводим результат на экран
Console.WriteLine("Точка пересечения прямых: (" + x + ", " + y + ")");

