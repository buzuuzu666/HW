// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void DegreeNum (int num, int degree)
{
    int result = num;
    for (int i = 1; i < degree; i++)
    {
        result = result * num;
    }
    Console.WriteLine(result);
}

DegreeNum(3, 5); 
*/

// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void SumNum (int num)
{
    int sum = 0;
    while (num > 0) 
    {
        int i = num % 10; // получаем хвост для произведения
        num /= 10; // отрезаем хвост
        sum += i; // произведение хвоста с хвостом

    }
    Console.WriteLine($"Сумма чисел = {sum}");
}

SumNum(9012);
*/


// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int [] CreateArray (int size_array) // создание массива с указанием его размера
{
    int [] randomArray = new int [size_array];
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(1, 101);
    }
    return randomArray;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int [] newArray = CreateArray(8);
ShowArray(newArray);
*/





