// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void SecondNumber (int number)
{
    if (number > 99 && number < 1000)
    {
        int dec_num = number / 10;
        int ed_num = dec_num % 10;
        Console.Write($"Введеное число {number}, вторая цифра числа: {ed_num}");
    }
    else
    {
        Console.Write("Введите трехзначое число");
    }
   
}

SecondNumber(753);
*/


// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void LastNumber (int number)
{
    if (number > 99)
    {
        while (number > 999)
        {
            number = number / 10;
        }

        number = number % 10;
        Console.Write($"{number}");       
    }
    else
    {
        Console.Write($"Третьей цифры нет");
    }
}

LastNumber(4583);
*/


// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void WeekDay (int number)
{
    if (number < 6 && number > 0)
    {
        Console.Write("нет");
    }
    else if (number > 5 && number < 8)
    {
        Console.Write("да");
    }
    else
    {
        Console.Write("введите верное число, от 1 до 7 включительно.");
    }
}

WeekDay(4);
*/