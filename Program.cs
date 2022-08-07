// Console.WriteLine("Hello, World!");

Console.Clear();

// Homework_Seminar1

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int number1 = 0;
int number2 = -9;
int max = number1;
int min = number2;
if (number2 > max)
{ 
    max = number2;
    min= number1;
}

Console.WriteLine("Больше "  + max);
Console.WriteLine("Меньше " + min);




