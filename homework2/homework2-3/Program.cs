/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.3
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7)");
int number1 = int.Parse(Console.ReadLine());
if (number1 >= 6) {
  Console.WriteLine("Этот день является выходным");  
}
else {
  Console.WriteLine("Этот день не является выходным");  
}