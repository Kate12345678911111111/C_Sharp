// Console.WriteLine("Hello, World!");

Console.Clear();

// // Homework_Seminar1

// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.Write("Введите числа: ");

// int number1 = Convert.ToInt32(Console.ReadLine());

// int number2 = Convert.ToInt32(Console.ReadLine());

// int max = number1;

// int min = number2;

// if (number2 > max)
// { 
//     max = number2;
//     min= number1;
// }

// Console.WriteLine("Больше "  + max);
// Console.WriteLine("Меньше " + min);


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// Console.Write("Введите число 1: ");

// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 2: ");

// int B = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 3: ");
// int C = Convert.ToInt32(Console.ReadLine());

// int max = A;

// if (B>max) max = B;
// if (C > max) max = C;

// Console.WriteLine("Максимальное число " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int C = number % 2;

// if (C == 0)
// {
// Console.WriteLine(number + " - Четное число");
// }

// else 
// {

// Console.WriteLine(number + "- Нечетное число");
// };


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");

// int N = Convert.ToInt32(Console.ReadLine());

// int D = 2;
// while (D <= N)

//   { int G = D % 2;
//     if  (G == 0)
//     {
//         Console.Write(D + " "); 
//     }
//     D++;
// }
