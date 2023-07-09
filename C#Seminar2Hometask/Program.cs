// // Задача 10
// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
    
// Console.WriteLine("Введите трёхзначное число:");
// int number = int.Parse(Console.ReadLine());

// int secondDigit = (number / 10) % 10;

// Console.WriteLine("Вторая цифра числа: " + secondDigit);
    


// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char thirdDigit = number[2];
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}