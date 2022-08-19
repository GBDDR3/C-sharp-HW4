// Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число А ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());
int RaiseDigree(int numberA, int numberB)
{
    int number = Convert.ToInt32(Math.Pow(numberA,
    numberB));
    return number;
}
int result = RaiseDigree(numberA, numberB);
Console.WriteLine(result);