// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 100;
// Console.WriteLine($"{number1}");

if(number >= 100 && number <= 999)
{
  int number2 = number1 / 10;
  Console.WriteLine($"{number2}");
}

