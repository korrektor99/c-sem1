// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] array = new int[4, 4];
Random rand = new Random();
int[] sum = new int[4];
int min = 0;
Console.WriteLine("исходный массив");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(-10, 10);
        Console.Write($"|{array[i, j]}|    ");
        if (i == 0)
        {
            sum[i] = sum[i] + array[i, j];
        }
        else if (i == 1)
        {
            sum[i] = sum[i] + array[i, j];
        }
        else if (i == 2)
        {
            sum[i] = sum[i] + array[i, j];
        }
        else if (i == 3)
        {
            sum[i] = sum[i] + array[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("массив сумм строк");
for (int i = 0; i < 4; i++)
{
    if (sum[i] < min)
    {
        min = sum[i];
    }
    Console.Write($"|{sum[i]}|    ");

}
for (int i = 0; i < 4; i++)
{
    if (sum[i] == min)
    {
        Console.WriteLine($"индекс минимальной суммы строки   {i}");
    }
}
Console.WriteLine($"Минимальная сумма строки (для наглядности)  {min}");