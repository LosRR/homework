/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число");
string numberFirst = Console.ReadLine();
int number1 = int.Parse(numberFirst);
int TwoDigit = number1 % 100;
int MidDigit = TwoDigit / 10;
Console.WriteLine($"Вторая цифра этого числа - {MidDigit}");