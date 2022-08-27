
//Seminar 1

/ Seminar 3
// Console.Write("введите случайное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(number) < 100)
// {
//     Console.Write("третьей цифры нет");
// }
// else
// {
//     while (Math.Abs (number) >= 1000)
//     {
//         number = number / 10;
//     }
//     Console.Write(Math.Abs(number = number % 10));
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Homework
// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 7 && number < 1)
// {
//     Console.WriteLine("Неверный день недели");
// }
// if (number > 5 && number < 8)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else
// {
//     Console.WriteLine("Определить четверть невозможно");
//     }

// int returnQuarter(int a, int b)
// {
//     if (a > 0 && b > 0)
// {
//     return 1;
// }
// else if (a > 0 && b < 0)
// {
//     return 2;
// }
// else if (a < 0 && b < 0)
// {
//     return 3;
// }
// else if (a < 0 && b > 0)
// {
//     return 4;
// }
// else
// {
//     return 0;
//     }

// }

// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(returnQuarter(x,y));
// int quarter = returnQuarter(x,y);
// Console.WriteLine($"Четверть: {quarter}");

// Void printQuarter(int a, int b)
// {
//     if (a > 0 && b > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (a > 0 && b < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else if (a < 0 && b < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (a < 0 && b > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else
// {
//     Console.WriteLine("Определить четверть невозможно");
//     }

// }

// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// printQuarter(x,y);


// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// for(int i=1; i<=N; i++)
// {
//     Console.Write($"{i*i} ");

// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

// Console.Clear();
// Console.Write("введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

// Console.WriteLine($"d={d:f2}");

// Seminar 4

// напишите программу,которая принимает на вход число А и выдает сумму чисел от 1 до А



// int GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.Clear();

// Console.WriteLine($"Сумма цифр от 1 до введенного числа: {GetSumNums(10)}");
// Console.WriteLine($"Сумма цифр от 1 до введенного числа: {GetSumNums(7)}");

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());


// Напишите программу, которая принимает на вход число и выдает количество чисел в числе



// void N(int x)

// {
//     int count = 0;
//     while ( x != 0)
// {
//     x = x / 10;
//     count++;
// }
// Console.WriteLine($"Введенное число имеет {count} знака");
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// N (number);

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


// Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9. Посчитать сумму положительных чисел и сумму отрицательных чисел

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

// int[] Katearray = CreateRandomArray(12, -9, 9);
// ShowArray(Katearray);
// Console.WriteLine("---------------------------------");

// int sum_pos = 0;
// int sum_neg = 0;
// for (int i = 0; i < Katearray.Length; i++)
// {
//     if (Katearray[i] > 0)
//         sum_pos += Katearray[i];
//     else
//         sum_neg += Katearray[i];
// }
// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");


//  Напиши программу замена элементов массива: положительные элементы замените на отрицательные и наоборот

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

//     int[] Newarray = CreateRandomArray(12, -9, 9);
//     ShowArray(Newarray);

// for (int i = 0; i < Newarray.Length; i++)
// {
//     Newarray[i] *=  -1;
// }
// ShowArray(Newarray);

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


// Seminar 7

// Console.Write("Введите через пробел b1, k1, b2, k2: ");
// string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); // удаление пробелов

// double b1 = double.Parse(f[0]);
// double k1 = double.Parse(f[1]);
// double b2 = double.Parse(f[2]);
// double k2 = double.Parse(f[3]);

// Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

// double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
// {
//     double[] result = new double[2];
//     result[0] = (inB2 - inB1) / (inK1 - inK2);
//     result[1] = inK1 * result[0] + inB1;
//     return result;

}