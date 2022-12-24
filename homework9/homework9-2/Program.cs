/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите число больше 1");
        }
    }
    return result;
}
void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}
int m = GetNumber("Ввведите число (M) большее 1: ");
int n = GetNumber("Ввведите число (N) большее 1: ");
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"M = {m}, N = {n} ->");
PrintSum(m, n, temp = 0);