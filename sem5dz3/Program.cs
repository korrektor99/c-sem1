// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество чисел в массиве");
int N = int.Parse(Console.ReadLine()) ;  
double[] array= new double[N];
Random rand = new Random();
double max=0;
double min=1000000;
for(int y=0;y<N;y++)
{
    array[y]=rand.NextDouble()*100;
    Console.WriteLine("A[{0}]={1}",y, array[y]);
    if (array[y]>max)                    
    {
        max=array[y];
    }
    if (array[y]<min)                    
    {
        min=array[y];
    }
}Console.WriteLine($"максимальное {max}, минимальное {min}");

 Console.WriteLine($"разница между мин и макс элементами массива {max-min}");

