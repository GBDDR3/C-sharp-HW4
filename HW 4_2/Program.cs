// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int arg)
{
    int SumNumbers = 0;
    for (int i = 0; number != 0; i++)
    {
        SumNumbers = SumNumbers + number % 10;
        number /= 10;
    }
    return SumNumbers;
}
int result = SumNumbers(number);
Console.WriteLine(result);
