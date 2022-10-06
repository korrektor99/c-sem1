// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве
Console.WriteLine("Введите количество чисел в массиве");
int N = int.Parse(Console.ReadLine()) ;  
int[] array= new int[N];
Random rand = new Random();
int count=0;
for(int y=0;y<N;y++)
{
    array[y]=rand.Next(99,999);
    Console.WriteLine("A[{0}]={1}",y, array[y]);
    if (array[y]%2==0)
    {
        count++;
    }
 Console.WriteLine($"колличество четных чисел в массиве {count}");
