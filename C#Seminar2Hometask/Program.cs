// // Задача 10
// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
    
// Console.WriteLine("Введите трёхзначное число:");
// int number = int.Parse(Console.ReadLine());

// int secondDigit = (number / 10) % 10;

// Console.WriteLine("Вторая цифра числа: " + secondDigit);
    


// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число:");
// string number = Console.ReadLine(); // Хранит последовательность символов в переменной "number", "string" - текстовая строка

// if (number.Length < 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     char thirdDigit = number[2]; // Хранит один единственный "третий" символ в переменной "thirdDigit"
//     Console.WriteLine("Третья цифра числа: " + thirdDigit);
// }



// Задача 15 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели (1-7):");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7) // если цифра дня это 6 или 7
{
    Console.WriteLine("Это выходной день.");
}
else
{
    Console.WriteLine("Это рабочий день.");
}