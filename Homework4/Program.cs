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