// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] array = new int[4, 4];
int[,] array1 = new int[4, 4];
Random rand = new Random();
Console.WriteLine("исходный массив 1 ");
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = rand.Next(-10, 10);
        Console.Write($"|{array1[i, j]}|    ");
    }
    Console.WriteLine();
}
int[,] array2 = new int[4, 4];
Console.WriteLine("исходный массив 2");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = rand.Next(-10, 10);
        Console.Write($"|{array2[i, j]}|    ");
    }
    Console.WriteLine();
}
Console.WriteLine("Произведение массивов");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array[i,j]=array1[i,j]*array2[i,j];
        Console.Write($"|{array[i, j]}|    ");
    }
    Console.WriteLine();
}