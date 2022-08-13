
Console.Clear();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Homework


// Console.Write("Введите трехзначное число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int secondNum = number / 10 % 10;

// Console.WriteLine("Вторая цифра в числе: " + secondNum);

// Seminar 3
// int number = new Random().Next(100, 1000);
// int secondNum = number / 10 % 10;
// Console.WriteLine($"Вторая цифра в числе {number} -> {secondNum}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Homework

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0 && number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");

// }
// else
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }

//     int thirdnum = number % 10;
//     Console.WriteLine("Третья цифра " + thirdnum);
// }

// Seminar 3
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


