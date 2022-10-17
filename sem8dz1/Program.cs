//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] array = new int[4, 4];
Random rand = new Random();
int container = 0;
Console.WriteLine("исходный массив");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(-10, 10);
        Console.Write($"|{array[i, j]}|    ");
    }
    Console.WriteLine();
}
Console.WriteLine("сортировка по строкам массива");
int count=0;
while (count<array.GetLength(0))
{
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        if (array[i, j+1] < array[i, j])
        {
            container = array[i, j + 1];
            array[i, j+ 1] = array[i, j];
            array[i, j] = container;
        }
    }
}
count++;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"|{array[i, j]}|    ");
    }
    Console.WriteLine();
}