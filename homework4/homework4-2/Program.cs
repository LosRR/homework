/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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
int numb = GetNumber("введите число больше 1");
int sum = 0;
while (numb > 0)
{
int num = numb % 10;
numb = numb / 10;
sum = sum + num;
}
Console.WriteLine($"Сумма цифр в веденном числе = {sum}");