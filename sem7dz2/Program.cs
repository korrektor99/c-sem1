//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите m");
int m= int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите строку элемента который вы хотите увидеть (помните,что отсчет начинается с 0)");

int y= int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец элемента который вы хотите увидеть (помните,что отсчет начинается с 0)");
int g= int.Parse(Console.ReadLine());
double[,] array= new double[m, n];
Random rand = new Random();
for(int i=0;i<m;i++)
{
    for(int j=0;j<n;j++)
    {
        array[i,j]=rand.Next(-10,10);
        Console.Write($"|{array[i,j]}|    ");
    }
    Console.WriteLine();
}
if(y<m&&g<n&&y>-1&&g>-1)
{
    Console.WriteLine($"|{array[y,g]}|    ");
}
else
{
 Console.WriteLine($" элемента нет в этом массиве");
}