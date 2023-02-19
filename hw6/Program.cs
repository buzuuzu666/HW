// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int [] CreateArray (int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowCountArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
        count++;
    }
     Console.WriteLine();
     Console.WriteLine(count);
}

Console.WriteLine("Введите кол-во проверяемых чисел");
int size_array = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size_array);
ShowCountArray(array);
*/


// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.

/*
double [] Intersection (int b1, int b2, int k1, int k2)
{
    double [] array = new double[2];
    array[0] = Math.Round((double) (b1 - b2) / (k2 - k1), 1);
    array[1] = Math.Round(k1 * array[0] + b1, 1);
    return array;
}


void ShowArray (double [] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
     Console.WriteLine();
}

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] array = Intersection(b1, b2, k1, k2);
ShowArray(array);
*/
