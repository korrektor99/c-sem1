//  Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить 
//случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них
int[] array= new int[10];
Random rand = new Random();
int max = 0;
for(int y=0;y<10;y++)
{
    array[y]=rand.Next(-10,10);
    Console.WriteLine("A[{0}]={1}",y, array[y]);
    if (array[y]>max)
    {
        max=array[y];
    }

}
 Console.WriteLine($"max= {max}");
