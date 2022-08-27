
// Console.Clear();

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

/