// Random random = new Random();
// int randomNumber = random.Next(100, 1000);
// Console.WriteLine("Сгенерированное трехзначное число: " + randomNumber);

// int firstDigit = randomNumber / 100;    // Получаем первую цифру числа
// int thirdDigit = randomNumber % 10;     // Получаем третью цифру числа

// int newNumber = firstDigit * 10 + thirdDigit;   // Формируем новое число без второй цифры

// Console.WriteLine("Число после удаления второй цифры: " + newNumber);
    

//  Console.WriteLine("Введите первое число:");
//         int number1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите второе число:");
//         int number2 = int.Parse(Console.ReadLine());

//         if (number2 % number1 == 0)
//         {
//             Console.WriteLine(number2 + " является кратным числу " + number1);
//         }
//         else
//         {
//             int remainder = number2 % number1;
//             Console.WriteLine(number2 + " не является кратным числу " + number1);
//             Console.WriteLine("Остаток от деления: " + remainder);
//         }

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число");
int number2 = int.Parse(Console.ReadLine());

if (number2 % number1 == 0)
{
    Console.WriteLine("Число" + number2 + "является кратным числу " + number2;
}
else
{
    int reminder = number2 % number1;
    Console.WriteLine("Число" + number2 + " не является кратным числу " + number1);
    Console.WriteLine("Остаток от деления " + reminder);
}
