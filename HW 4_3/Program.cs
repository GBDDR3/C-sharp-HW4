// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите колиество элементов массива:\t");
int count = Convert.ToInt32(Console.ReadLine());

int[] WriteArray(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число с индексом {i}:\t");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] result = WriteArray(count);

Console.WriteLine("Вывод массива: ");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]);
    Console.Write(" ");
}