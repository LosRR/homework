/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
string NumberText = Convert.ToString(number1);
if (NumberText.Length > 2)
{
  Console.WriteLine("Третья цифра заданного числа:" + NumberText[2]);
}
else
{
  Console.WriteLine("В заданном числе третьей цифры нет");
}