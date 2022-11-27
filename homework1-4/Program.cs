/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число N, N должно быть больше 1");
string numberFirst = Console.ReadLine();
int number1 = int.Parse(numberFirst);
Console.WriteLine("все чётные числа от 1 до N: ");
for (int i = 2; i <= number1; i = i + 2)
{
    Console.WriteLine($"{i}");
}