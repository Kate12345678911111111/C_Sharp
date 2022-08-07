// Console.WriteLine("Hello, World!");

Console.Clear();

// // Homework_Seminar1

// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// int number1 = 9;
// int number2 = -9;
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

// int a = 22;
// int b = 3;
// int c = 9;

// int max = a;

// if (b>max) max = b;
// if (c > max) max = c;

// Console.WriteLine("Максимальное число " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


int number = 7;

int C = number % 2;

if (C == 0)
{
Console.WriteLine(number + " - Четное число");
}

else 
{

Console.WriteLine(number + "- Нечетное число");
}
