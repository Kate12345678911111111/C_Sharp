// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();

// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write("{0,6:F2}", arr[i, j]);
//         }
//         Console.WriteLine();

//     }
// }
// void FillArray(double[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.NextDouble() * 100;
//         }
//     }
// }
// double[,] Katearray = new double[4, 3];
// FillArray(Katearray);
// Console.WriteLine();
// PrintArray(Katearray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Clear();
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();

    }
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] Katearray = new int[4, 7];
FillArray(Katearray);
Console.WriteLine();
PrintArray(Katearray);

Console.Write("Введите номер строки массива от 0 до ...: ");
int numrows = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца массива от 0 до ...: ");
int numcolumns = int.Parse(Console.ReadLine());

int P = 0;
if (numrows < Katearray.GetLength(0) && numcolumns < Katearray.GetLength(1))
{
    for (int i = 0; i < Katearray.GetLength(0); i++)
    {
        for (int j = 0; j < Katearray.GetLength(1); j++)
        {
            P = Katearray[numrows, numcolumns];
        }
    }
    Console.WriteLine($"Значение элемента массива при ввеных данных о номере строки и столбца массива: {P} ");
}

else
    Console.WriteLine("Такого элемента массива нет");




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// Console.Clear();

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();

//     }
// }
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// int[,] Katearray = new int[4, 5];
// FillArray(Katearray);
// Console.WriteLine();
// PrintArray(Katearray);

// int columns = 0;
// for (int j = 0; j < Katearray.GetLength(1); j++)
// {
//     double sum = 0;
//     int count = 0;
//     double aver = 0;
//     for (int i = 0; i < Katearray.GetLength(0); i++)
//     {
//         sum = sum + Katearray[i, j];
//         count++;
//         aver = sum / count;

//     }
//     columns++;
//     Console.WriteLine($"Сумма элементов {columns} столбца двумерного массива:  {sum}");
//     Console.WriteLine($"Cреднее арифметическое элементов {columns} столбца двумерного массива:   {aver:f2}");
// }



