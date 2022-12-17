/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void GetAverage(int[,] matrix)
{
for (int f = 0; f < matrix.GetLength(1); f++)
        {
            double avarage = 0;
            for (int g = 0; g < matrix.GetLength(0); g++)
            {
                avarage = (avarage + matrix[g, f]);
            }
            avarage = avarage / matrix.GetLength(0);
            Console.Write(avarage + "; ");
        }
}
int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m, n);
Console.WriteLine("Вот наш массив: ");
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
GetAverage(matrix);