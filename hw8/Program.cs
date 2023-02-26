// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Create2dArray (int rows, int columns) 
{
    int [,] new2dArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            new2dArray[i,j] = new Random().Next(1, 21);
        }
    }
    return new2dArray;
}

void Show2dArray (int [,] array)
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
int [,] SortArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k + 1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = temp;
                }
            }
        }
    }
    return array;
}

int [,] array_2d = Create2dArray(4,4);
Show2dArray(array_2d);
int [,] sort_array = SortArray(array_2d);
Show2dArray(sort_array);
*/


// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void SumMatrix(int[,] matrix) // находим суммы строк массива
{
    int[] sumMatrix = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumMatrix[i] = sum;
    }
    int minSum = sumMatrix[0];
    int row = 0;
    for (int i = 1; i < sumMatrix.Length; i++)
    {
        if (minSum > sumMatrix[i])
        {
            minSum = sumMatrix[i];
            row = i;
        }
    }
    Console.WriteLine($"Найменьшая сумма {minSum}. \nНомер строки с наименьшей суммой элементов: {row + 1} строка");
}

int [,] array_2d = Create2dArray(4,9);
Show2dArray(array_2d);
SumMatrix(array_2d);
*/

//Задача 57: 
//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void SearchNumber(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) count++;
        }
    }
    Console.WriteLine($"Элемент ({num}) встречается {count} раз-(a)");
}

int [,] array_2d = Create2dArray(7,4);
Show2dArray(array_2d);
SearchNumber(array_2d, 4);