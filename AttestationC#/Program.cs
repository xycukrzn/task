// //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// {
//     int N = 5;
//     Console.WriteLine("Натуральные числа от N до 1: " + PrintNaturalNumbers(N));
// }

// static string PrintNaturalNumbers(int N)
// {
//     if (N == 1)
//     {
//         return "1";
//     }
//     else
//     {
//         return N + ", " + PrintNaturalNumbers(N - 1);
//     }
// }

// //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// {
//     int M = 1;
//     int N = 15;
//     Console.WriteLine("Сумма натуральных чисел от M до N: " + SumNaturalNumbers(M, N));
// }

// static int SumNaturalNumbers(int M, int N)
// {
//     if (M > N)
//     {
//         return 0;
//     }
//     else
//     {
//         return M + SumNaturalNumbers(M + 1, N);
//     }
// }

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

{
    int m = 2;
    int n = 3;
    Console.WriteLine("A(" + m + ", " + n + ") = " + AckermannFunction(m, n));
}

static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}