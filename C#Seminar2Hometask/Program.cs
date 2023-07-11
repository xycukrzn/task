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



// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// // или сообщает, что третьей цифры нет.

// string mess = "Введите число: ";
// int number1 = Prompt(mess);
// int number2 = Prompt("Введите пятизначное число");

// int result1 = FindThirdNumber(number1);
// int result2 = FindThirdNumber(number2);

// GetResult(result1);
// GetResult(result2);



// void GetResult(int res)
// {
//     if (res == -1)
//     {
//         Console.WriteLine("Такой цифры нет! ");
//     }
//     else
//     {
//         Console.WriteLine($"Третья цифра числа {res}");
//     }
// }



// int Prompt(string message)
// {
//     Console.Clear();
//     Console.WriteLine(message);
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     return num;
// }

// int FindThirdNumber(int num)
// {
//     if (num < 100)
//     {
//         return -1;

//     }
//     else
//     {
//         while (num >= 1000)
//         {
//             num = num / 10;
//         }
//         int thirdNumber = num % 10;
//         return thirdNumber;
//     }
// }



// Задача 15 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите цифру дня недели (1-7):");
// int day = int.Parse(Console.ReadLine());

// if (day == 6 || day == 7) // если цифра дня это 6 или 7
// {
//     Console.WriteLine("Это выходной день.");
// }
// else
// {
//     Console.WriteLine("Это рабочий день.");
// }



Console.WriteLine("Введите координату X:");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y:");
double y = double.Parse(Console.ReadLine());

int quadrant;

if (x > 0 && y > 0)
{
quadrant = 1;
}
else if (x < 0 && y > 0)
{
     quadrant = 2;
}
else if (x < 0 && y < 0)
{
    quadrant = 3;
}
else
{
    quadrant = 4;
}
{
Console.WriteLine("Точка находится в четверти: " + quadrant);
}