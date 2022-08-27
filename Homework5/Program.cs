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

// int max = 0;
// int min = 0;
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


// Seminar 6
// double[]asd = new double[5];
// asd[0] = new Random().Next() + new Random().Next();


//Двумерные массивы

// Console.Clear();
// int[,] array = new int[3, 4] // 3 строки, 4 столбца (4 элемента в каждой строке)
// {
//     {1,2,3,4},
//     {5,6,7,8},
//     {9,10,11,12}
// };

// Console.WriteLine("Количество строк: " + array.GetLength(0));
// Console.WriteLine("Количество столбцов: " + array.GetLength(1));

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         // array[i,j]= new Random().Next(1,10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

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
// int[] Katearray = CreateRandomArray(10, -9, 10);
// ShowArray(Katearray);
// Console.WriteLine();

// for (int i = Katearray.Length - 1; i >= 0; i--)
// {
//     Console.Write($"{Katearray[i]} ");

// }




// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33


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
// int[] Katearray = CreateRandomArray(10,-9, 10);
// ShowArray(Katearray);
// Console.WriteLine();

// double sum = 0;
// int count = 0;
// for (int i = 0; i < Katearray.Length; i++)
// {
//     if (Katearray[i] > 0)
//         sum = sum + Katearray[i];
//     count++;
// }
// Console.WriteLine($"{String.Join(", ",Katearray)}");
// Console.WriteLine($"Сумма положительных элементов массива: {sum}, среднее арифметическое положительных элементов {sum / count}");



// int[] asd = new int[] { 0, 1, 2, 3 };
// for (int i = 0; i < asd.Length; i++)
// {
//     Console.WriteLine(asd[i]);
// }
// string str = string.Join(", ", asd);
// Console.WriteLine(str);


// string str = "1,2,3,4";
// string[] strArray = str.Split(' ');

// for (int i = 0; i < strArray.Length; i++)
// {
//     Console.WriteLine (strArray[i]);
// }

// int[] array = new int[strArray.Length];
// array[i] = int.Parse(strArray[i]);