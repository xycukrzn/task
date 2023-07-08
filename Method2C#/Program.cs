        Random random = new Random();
        int randomNumber = random.Next(100, 1000);
        Console.WriteLine("Сгенерированное трехзначное число: " + randomNumber);

        int firstDigit = randomNumber / 100;    // Получаем первую цифру числа
        int thirdDigit = randomNumber % 10;     // Получаем третью цифру числа

        int newNumber = firstDigit * 10 + thirdDigit;   // Формируем новое число без второй цифры

        Console.WriteLine("Число после удаления второй цифры: " + newNumber);
    
