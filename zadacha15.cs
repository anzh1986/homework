﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if ((day > 7))
{
    Console.WriteLine ("введите число от 1 до 7");
}
else

{
    if (day == 1)
    {
    Console.WriteLine ("НЕТ");
    }
    if (day == 2)
    {
    Console.WriteLine ("НЕТ");
    }
    if (day == 3)
    {
    Console.WriteLine ("НЕТ");
    }
    if (day == 4)
    {
    Console.WriteLine ("НЕТ");
    }
    if (day == 5)
    {
    Console.WriteLine ("НЕТ");
    }
    if (day == 6)
    {
    Console.WriteLine ("ДА");
    }
    if (day == 7)
    {
    Console.WriteLine ("ДА");
    }
}