﻿/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите число 1");
string numberFirst = Console.ReadLine();
int number1 = Convert.ToInt32(numberFirst);

Console.WriteLine("Введите число 2");
string numberSecond = Console.ReadLine();
int number2 = Convert.ToInt32(numberSecond);

if(number1 > number2)
{
Console.WriteLine($"max = {number1}, min = {number2}");
}
else
{
Console.WriteLine($"max = {number2}, min = {number1}");
}