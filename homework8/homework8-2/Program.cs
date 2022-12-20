/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка
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
            matrix[i, j] = rnd.Next(1, 10);
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
int FindMinLine(int[,] matrix)
{
    int temp = 0;
    int minSumLine = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSumLine += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSumLine > sum)
        {
            minSumLine = sum;
            temp = i;
        }
    }
    temp = temp + 1;
    return temp;
}

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m, n);
Console.WriteLine("Вот наш массив: ");
PrintMatrix(matrix);
int minLine = FindMinLine(matrix);
Console.WriteLine($"{minLine} - строкa с наименьшей суммой элементов ");