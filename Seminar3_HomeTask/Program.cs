// Task1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.Write("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine());

// // Проверяем, является ли число палиндромом
// if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10) {
//     Console.WriteLine("Число является палиндромом.");
// }
// else {
//     Console.WriteLine("Число не является палиндромом.");
// }


// // Task2
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// {    
//     Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
//     double x1 = double.Parse(Console.ReadLine()); // Считываем координату x1 и преобразуем в тип double
//     double y1 = double.Parse(Console.ReadLine());
//     double z1 = double.Parse(Console.ReadLine());

//     Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
//     double x2 = double.Parse(Console.ReadLine());
//     double y2 = double.Parse(Console.ReadLine());
//     double z2 = double.Parse(Console.ReadLine());

//     double distance = CalculateDistance(x1, y1, z1, x2, y2, z2); // Вычисляем расстояние между точками
//     Console.WriteLine("Расстояние между двумя точками: " + distance);
// }

// static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2) // Метод для вычисления расстояния между двумя точками в 3D-пространстве. Принимает координаты двух точек: (x1, y1, z1) и (x2, y2, z2)
// {
//     double deltaX = x2 - x1;
//     double deltaY = y2 - y1;
//     double deltaZ = z2 - z1;

//     double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
//     return distance;
// }


// Task3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");

for (int i = 1; i <= N; i++)
{
    int cube = i * i * i;
    Console.WriteLine(i + "^3 = " + cube);
}