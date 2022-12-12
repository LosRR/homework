/*
Задача 45: Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
       array[i] = rnd.Next(1,9);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    Console.Write("]");
    Console.WriteLine();
}
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите число");
        }
    }
    return result;
}
int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}
int dimension = GetNumber("Введите размерность массива");
int[] startArray = InitArray(dimension);
Console.WriteLine("Вот наш случайный массив: ");
PrintArray(startArray);
int[] resultArray = CopyArray(startArray);
Console.WriteLine("Вот копия массива: ");
PrintArray(resultArray);