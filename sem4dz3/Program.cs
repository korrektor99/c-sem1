// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine()) ;
int[] array= new int[N];
Random rand = new Random();
for(int y=0;y<N;y++)
{
    array[y]=rand.Next(-10,10);
    Console.WriteLine("A[{0}]={1}",y, array[y]);
}
//for(int i=0;i<(N);i++)
//{
  //  Console.WriteLine("A[{0}]= {1}",i, array[i]);
//}