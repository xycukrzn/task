// задача рандомное число от 10 до 99 и показывает наибольшую цифру числа 



int GetRandomNumber()
{
    int number = new Random().Next(10,100);
    Console.WriteLine(number);
    return number;
}

int GetFirstDigit(int number1)
{
    //number1 = number1/10;
    return number1 / 10;
}

int GetLastDigit(int number1)
{
    return number1 / 10
}

void PrintNumber(int num1)
{
    Console.WriteLine(num1);
}

int num = GetRandomNumber();
PrintNumber(num);
int firstDigit = GetFirstDigit(num);
PrintNumber(firstDigit);
int lastDigit = GetLastDigit(num);
PrintNumber(lastDigit);