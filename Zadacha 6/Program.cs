﻿// Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//             4 -> да
//             -3 -> нет
//              7 -> нет

int x;
Console.WriteLine("Введите целое число.");
x = Convert.ToInt32(Console.ReadLine());
if (x%2==0) 
{
Console.WriteLine("Четное Число");    
}
else
{
    Console.WriteLine("Нечетное число");
}
