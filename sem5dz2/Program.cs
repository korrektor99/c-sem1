// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите количество чисел в массиве");
int N = int.Parse(Console.ReadLine()) ;  
int[] array= new int[N];
Random rand = new Random();
int sum=0;
for(int y=0;y<N;y++)
{
    array[y]=rand.Next(-999,999);
    Console.WriteLine("A[{0}]={1}",y, array[y]);
    if (y%2==0)                     //тк нужно считать нечетные элементы массива , прибавлять будем элементы с четным индексом тк индекс с 0 начинается
    {
        sum=sum+array[y];
    }
}
 Console.WriteLine($"сумма элементов на нечетных позициях {sum}");

