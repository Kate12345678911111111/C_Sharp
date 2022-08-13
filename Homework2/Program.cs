
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
// if (number < 100)
// {
//     Console.WriteLine($"Третьей цифры нет");
//     return;
//         }
// int thirdnum = number % 10;
// Console.WriteLine($"Третья цифра числа {number} ->{thirdnum}");

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

