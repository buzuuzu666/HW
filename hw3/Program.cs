// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Paliondrom (int number) //12345
{
    if (number > 0 && number <= 99999)
    {
        int thousend1 = number / 10000; 
        int thousend2 = number % 10000 / 1000; 
        int hundreds = number % 1000 / 100; 
        int dozens = number % 100 / 10; 
        int units = number % 10; 

        if (thousend1 == units && thousend2 == dozens)
        Console.WriteLine($"{number} -> да");
        else
        Console.WriteLine($"{number} -> нет");

    }
    else
    Console.WriteLine($"Введите пятизначное число");
}

Paliondrom(12321);
*/


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double DistanceAB (int xa, int ya, int ca, int xb, int yb, int cb)
{
    double deltaX = xa - xb;
    double deltaY = ya - yb;
    double deltaC = ca - cb;
    double distAB = Math.Sqrt(Math.Pow((deltaX), 2) + Math.Pow((deltaY), 2) + Math.Pow((deltaC), 2));
    return distAB;
}

double distAB = DistanceAB(3, 6, 8, 2, 1, -7);
Console.WriteLine(Math.Round(distAB, 2));
*/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write($"{current}={Math.Pow(current, 3)}, ");
        current++;
    }
}

Cube(8);
Console.Write("\b\b.");
*/








