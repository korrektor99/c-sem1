// Задайте одномерный массив, заполненный случайными числами.
// Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива.
// Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
Console.WriteLine("Введите количество чисел в массиве");
int N = int.Parse(Console.ReadLine()) ;  
int[] array= new int[N];
int countchetnih=0;
int countnechetnih=0;
int ind=0;
int index=0;
int srarfm1=0;
int srarfm2=0;
Random rand = new Random();
for(int y=0;y<N;y++)
{
    array[y]=rand.Next(0,10);
    Console.WriteLine("A[{0}]={1}",y, array[y]);
    if (array[y]%2==0)
    {
        countchetnih++;
    }
    else
    {
        countnechetnih++;
    }
}
Console.WriteLine("________________");
int[] chetni= new int [countchetnih];
int[] nechetnie= new int [countnechetnih];
for(int y=0;y<N;y++)
{
    if (array[y]%2==0)
    {
        chetni[ind]= array[y];
        ind++;
    }
    else
    {
        nechetnie[index]= array[y];
        index++;
    }
}
for (int i=0;i<countchetnih;i++)
{
Console.WriteLine("B[{0}]={1}",i, chetni[i]);
    srarfm1+=chetni[i];
}
Console.WriteLine("________________");
 for (int i=0;i<countnechetnih;i++)
 {
    srarfm2+=nechetnie[i];
    Console.WriteLine("C[{0}]={1}",i, nechetnie[i]);
 }
 
 if (srarfm1>srarfm2)
 {
    Console.WriteLine($"среднее арифметическое четных  {srarfm1}>среднее арифметическое нечетных  {srarfm2}");
 }
 else
 {
    Console.WriteLine($"среднее арифметическое четных  {srarfm1}  <среднее арифметическое нечетных  {srarfm2}");
 }