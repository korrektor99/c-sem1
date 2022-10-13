//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите m");
int m= int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
double[,] array= new double[m, n];
Random rand = new Random();
for(int y=0;y<m;y++)
{
    for(int j=0;j<n;j++)
    {
        array[y,j]=rand.NextDouble()*rand.Next(-1000,1000);
        Console.Write($"|{array[y,j]}|    ");
    }
    Console.WriteLine();
}
