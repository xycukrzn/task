// задача рандомное число от 10 до 99 и показывает наибольшую цифру числа 



Random random = new Random();
        int randomNumber = random.Next(10, 100);
        Console.WriteLine("Сгенерированное число: " + randomNumber);

        int maxDigit = 0;
        int number = randomNumber;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > maxDigit)
            {
                maxDigit = digit;
            }
            number /= 10;
        }

        Console.WriteLine("Наибольшая цифра числа: " + maxDigit);