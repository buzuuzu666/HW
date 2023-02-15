// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int [] RandomArray (int size_array, int min_value, int max_value)
{
    int [] new_array = new int[size_array];
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = new Random().Next(min_value, max_value);
    }
    return new_array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
     Console.WriteLine();
}
*/

/*
int EvenNumArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

int [] array = RandomArray(4, 100, 1000);
ShowArray(array);
int count = EvenNumArray(array);
Console.WriteLine($"Кол-во четных чисел в массиве = {count}");
*/


// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumElArray (int [] array)
{
    int sum_el = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum_el += array[i];
    }
    return sum_el;
}

int [] array = RandomArray(6, 1, 51);
ShowArray(array);
int sum_el = SumElArray(array);
Console.WriteLine($"Сумма элементов, на нечетных позициях = {sum_el}");
*/


// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать

double [] RandArray (int size_array, int min_value, int max_value)
{
    double [] array = new double[size_array];
    var num1 = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        
        double num2 = num1.NextDouble() * (max_value - min_value) + min_value;
        array[i] = Math.Round(num2, 1);
    }
    return array;
}

void ShowArray1 (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
}

double MinEl (double [] array)
{
    double min_el = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min_el)
            min_el = array[i];
    }
    return min_el;
}

double MaxEl (double [] array)
{
    double max_el = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max_el)
            max_el = array[i];
    }
    return max_el;
}

double [] array = RandArray(7, 1, 51);
ShowArray1(array);
double max = MaxEl(array);
double min = MinEl(array);
double result = max - min;
Console.Write(result);




