/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите число 1");
string numberFirst = Console.ReadLine();
int number1 = int.Parse(numberFirst);

Console.WriteLine("Введите число 2");
string numberSecond = Console.ReadLine();
int number2 = Convert.ToInt32(numberSecond);

Console.WriteLine("Введите число 3");
string numberThird = Console.ReadLine();
int number3 = Convert.ToInt32(numberThird);

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"max = {max}");