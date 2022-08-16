// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Введите пятизначное число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int firstNum = number / 10000;
// Console.WriteLine("Первая цифра в числе: " + firstNum);

// int secondNum = number / 1000 % 10;
// Console.WriteLine("Вторая цифра в числе: " + secondNum);

// int forthNum = number / 10 % 10;
// Console.WriteLine("Четвертая цифра в числе: " + forthNum);

// int fifthNum = number % 10;
// Console.WriteLine("Пятая цифра в числе: " + fifthNum);

// if (firstNum == fifthNum && secondNum == forthNum)

//     Console.WriteLine("Число является палиндромом");

// else
//     Console.WriteLine("Число не является палиндромом");


// Seminar 3
// Console.Clear();

// int number = new Random().Next(10000, 100000);
// Console.Write(number );

// int firstNum = number / 10000;
// int secondNum = number / 1000 % 10;
// int forthNum = number / 10 % 10;
// int fifthNum = number % 10;

// if (firstNum == fifthNum && secondNum == forthNum)

// Console.WriteLine(" Число является палиндромом");

// else
// Console.WriteLine(" Число не является палиндромом");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Clear();

// Console.Write("введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());


// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+Math.Pow(z1 - z2, 2));

// Console.WriteLine($"d={d:f5}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// int N1 = Math.Abs(N);
// for(int i=1; i<=N1; i++)
// {
//     Console.Write($"{i*i*i} ");

// }

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



void N(int x)

{
    int count = 0;
    while ( x != 0)
{
    x = x / 10;
    count++;
}
Console.WriteLine($"Введенное число имеет {count} знака");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
N (number);
