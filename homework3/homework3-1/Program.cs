/*
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
String number = Console.ReadLine();
void Checking(string number)
{
    if (number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine($"Введенное число {number} - палиндром");
    }
    else Console.WriteLine($"Введенное число {number} - НЕ палиндром");
}
if (number!.Length == 5)
{
  Checking(number);
}
else Console.WriteLine($"Введено неверное число");
