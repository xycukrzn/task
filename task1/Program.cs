// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

// Console.WriteLine("Введите первое число ");  
// int a = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите второе число ");
// int b = int.Parse(Console.ReadLine()); 
// if (a == (b*b) ) {
// Console.WriteLine ("Да, является квадратом ");
// }   
// else 
// {
// Console.WriteLine ("Нет, не является квадратом ");
// }


Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("День недели понедельник");
        break;
    case 2:
        Console.WriteLine("День недели вторник");
        break;
    case 3:
        Console.WriteLine("День недели среда");
        break;
    case 4:
        Console.WriteLine("День недели четверг");
        break;
    case 5:
        Console.WriteLine("День недели пятница УРА!");
        break;
    case 6:
        Console.WriteLine("День недели суббота");
        break;
    case 7:
        Console.WriteLine("День недели воскресенье");
        break;
    default:
        Console.WriteLine("День недели не задан");
        break;
}