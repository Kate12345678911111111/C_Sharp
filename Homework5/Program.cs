// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Clear();
// int N = new Random().Next(1, 100);
// Console.WriteLine("Длинна массива: " + N);
// int[] Katearray = CreateRandomArray(N, 100, 1000);
// ShowArray(Katearray);
// Console.WriteLine();


// int chet = 0;
// for (int i = 0; i < Katearray.Length; i++)
// {
//     if (Katearray[i] %2 == 0)
//         chet +=1;
// }
// Console.WriteLine($"Количество четных чисел: {chet}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();

// int[] Katearray = CreateRandomArray(12, -8, 9); //// int N = new Random().Next(1, 20);
// Console.WriteLine("Длинна массива: " + N);
// int start = new Random().Next(1, 20);
// Console.WriteLine("Начало диапазона массива: " + start);
// int end = new Random().Next(20, 40);
// Console.WriteLine("Конеw диапазона массива: " + end);
// int[] Katearray = CreateRandomArray(N, start, end);
// ShowArray(Katearray);
// Console.WriteLine();


// int sum_nechet = 0;
// for (int i = 0; i < Katearray.Length; i++)
// {
//     if (i %2 != 0)
//         sum_nechet += Katearray[i];
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum_nechet}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();

// int[] Katearray = CreateRandomArray(12, -8, 9);
// ShowArray(Katearray);
// Console.WriteLine();

// double max = 0;
// double min = 0;
// for (int i = 0; i < Katearray.Length; i++)
// {
//     if (Katearray[i] > max)
//         max = Katearray[i];
//     if (Katearray[i] < min)
//         min = Katearray[i];
// }
// Console.WriteLine($"Максимальный элемент массива: {max}, Минимальный элемент массива {min}");
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max-min}");





// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// // // выводит значения элементов через пробел

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);


