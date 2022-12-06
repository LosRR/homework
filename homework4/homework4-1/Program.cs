/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число, введите число большее 1");
        }
    }
    return result;
}
int numb1 = GetNumber("введите число больше 0");
int numb2 = GetNumber("введите число больше 0");
int numEnd = numb1;
for (int i = 1; i < numb2; i++)
{
    numEnd = numEnd * numb1;
}
Console.WriteLine($"{numEnd}");