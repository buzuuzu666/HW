// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

Console.Write("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);
*/

//Задача 66: 
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 < num2) return num1 + SumNaturalNumbers(num1 + 1, num2);
    if (num1 > num2) return num2 + SumNaturalNumbers(num1 - 1, num2);
    else return 0;
}

Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = SumNaturalNumbers(number1, number2);
Console.WriteLine($"{sum}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunkAkkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num2 == 0) return FunkAkkerman(num1 - 1, 1);
    return FunkAkkerman(num1 - 1, FunkAkkerman(num1, num2 - 1));
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = FunkAkkerman(m, n);
Console.WriteLine($"{result}");