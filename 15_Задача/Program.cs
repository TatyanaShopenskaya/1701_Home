﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет




Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
{
    if (num >0 && 8>num)
    {
        if (num > 5) Console.WriteLine("выходной");
        else Console.WriteLine("не выходной");
    }
    else Console.WriteLine("Ошибка. Введите число от 1 до 7 повторно");
}