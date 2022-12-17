/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите число");
        }
    }
    return result;
}
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CheckPosition(int[,] matrix)
{
    int a = GetNumber("Укажите строку искомого элемента: ");
    int b = GetNumber("Укажите столбец искомого элемента: ");
    if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {matrix[a - 1, b - 1]}");
    }
}
int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m, n);
Console.WriteLine("Вот наш массив: ");
PrintMatrix(matrix);
CheckPosition(matrix);