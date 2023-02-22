// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double [,] Create2dArray (int rows, int columns) // создание вещественного двумерного массива
{
    double [,] new2dArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            new2dArray[i,j] = Math.Round((new Random().Next(1, 21) + (new Random().NextDouble())), 2);
        }
    }
    return new2dArray;
}
*/
void Show2dArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
double [,] new2dArray = Create2dArray(3, 4);
Show2dArray(new2dArray);
*/

// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = Convert.ToInt32(new Random().Next(1,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t");
        Console.WriteLine();
}

 Console.Write("Введите строку: ");
 int user_rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите столбец: ");
 int user_columns = Convert.ToInt32(Console.ReadLine());

 if (user_rows > rows && user_columns > columns)
 Console.WriteLine("Такого числа нет");
 else
 {
 var c = array.GetValue(user_rows, user_columns);
 Console.WriteLine(c);
 }
*/

// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


double [,] Create2dArray (int rows, int columns)
{
    double [,] new2dArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            new2dArray[i,j] = new Random().Next(1, 21);
        }
    }
    return new2dArray;
}

double [] AverageArith (double [,] array)
{
    double [] average_array = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        average_array[i] = Math.Round(sum / array.GetLength(0), 1);
    }
    return average_array;
}

void ShowArray (double [] array)
{
    Console.WriteLine("Среднее арифметическое столбцов:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} \t");
    }
    Console.WriteLine();
}

double [,] new2dArray = Create2dArray(3, 4);
Show2dArray(new2dArray);
double [] average_array = AverageArith(new2dArray);
ShowArray(average_array);

