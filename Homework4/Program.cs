// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int C = Convert.ToInt32(Math.Pow(A,B));

// Console.WriteLine("A в степени B = " + C);


// Seminar 5

// Console.Clear();
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{A} в степени {B} = {Math.Pow(A, B)}");

// int MathPow(int num, int rank)
// {
//     if (B == 0) return 1;
//     int res = num;
//     for (int i = 2; i <= B; i++)
//     {
//         res *= num;
//     }
//     return res;
// }

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = Math.Abs(number);
// Console.WriteLine($" Сумма цифр = {GetSumnumbers(number1)}");

// int GetSumnumbers(int number1)
// {
//     int Sum = 0;
//     while (number1 > 0) // запускаем цикл, пока число больше 0
//     {
//         Sum += number1 % 10; // находим последнюю цифру числа и суммируем с суммой, которая в первой итерации равна 0
//         number1 /= 10; // уменьшаем число на разряд
//     };
//     return Sum;
// }


// Seminar 5
// Creat and Show massive

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }


// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[1] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// // выводит значения элементов через пробел

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


// / Напишите программу, которая задаёт массив 
// // из 8 элементов, заполненный нулями и единицами в случайном порядке

// Console.Clear();
// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(" - ", array)}]");// выводит любое значение функции или переменной. "," - сепаратор, String.Join - выводит строку


// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(3);
//     }

//     return result;
// }

// Напишите программу, которая задаёт массив 
// // из 8 элементов и выводит их на экран

// Console.Clear();
// int[] array = GetRandomArray(8,0,10);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue,maxValue);
//     }

//     return result;
// }