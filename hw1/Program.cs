// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} > {number2}");
}
else
{
    Console.WriteLine($"{number2} > {number1}");
}
*/


// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNum = number1;

if (number2 > number1)
{
    maxNum = number2;
}

if (maxNum > number3)
{
    Console.WriteLine($"Максимальное число {maxNum}");
}
else
{
    Console.WriteLine($"Максимальное число {number3}");
}
*/


// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
/*
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.WriteLine($"{number1} четное число");
}
else
{
    Console.WriteLine($"{number1} не четное число");
}
*/


// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < number1)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
        i++;
    }
    else 
    {
        i++;
    }
}
*/




