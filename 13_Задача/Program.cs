// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine()); 
int number3 = Search(number);

int Search(int number)
{
    while (number > 999) 
    {
        number = number / 10;
    }
    return number % 10;
}

if (number>-100 && number<100)
{
    Console.WriteLine("третьей цифры нет");
}

if (number < 0)
{
    number = number * (-1);
    Console.WriteLine(-number3);
}
else
{
    number3 = Search(number);
    Console.WriteLine(number3);
}


