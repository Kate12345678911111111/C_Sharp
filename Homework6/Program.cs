﻿//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// double[] CreateRandomArray(double M, double start, double end)
// {
//     double[] RandomArray = new double[M];
//     for (double i = 0; i < M; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(double[] array)
// {
//     for (double i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Clear();
// double M = new Random().Next(1, 10);
// Console.WriteLine("Длинна массива: " + M);
// double[] Katearray = CreateRandomArray(M, -10, 10);
// Console.WriteLine($"{String.Join(", ",Katearray)}");


// double count = 0;
// for (double i = 0; i < Katearray.Length; i++)
// {
//     if (Katearray[i] > 0)
//         count++;
// }
// Console.WriteLine($"Количество чисел больше нуля: {count}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

Console.Write("введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 != k2)
{ 
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
Console.WriteLine($"x={x:f1}, y={y:f1}");
}

else
{
    Console.WriteLine("Прямые параллельны и пересекаться не могут");
}





