// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array= new int[4, 4];
Random rand = new Random();
int count1=0;
int count2=0;
int count3=0;
int count4=0;
int sum1=0;
int sum2=0;
int sum3=0;
int sum4=0;
for(int i=0;i<4;i++)
{
    for(int j=0;j<4;j++)
    {
        array[i,j]=rand.Next(-10,10);
        Console.Write($"|{array[i,j]}|    ");
        if(j==0)
        {
            sum1+=array[i,j];
            count1++;
        }
        else if(j==1)
        {
            sum2+=array[i,j];
            count2++;
        }
        else if(j==2)
        {
            sum3+=array[i,j];
            count3++;
        }
        else if(j==3)
        {
            sum4+=array[i,j];
            count4++;
        }
    }
    Console.WriteLine();
}
double srarf1=sum1/count1;//+sum1%count1;
double srarf2=sum2/count2;
double srarf3=sum3/count3;;
double srarf4=sum4/count4;
Console.WriteLine($" {count1} {sum1} {sum1%count1}");
 Console.WriteLine($"cреднее арeфметическое 1го столбца {srarf1}  ");
 Console.WriteLine($"cреднее арeфметическое 2го столбца {srarf2}  ");
 Console.WriteLine($"cреднее арeфметическое 3го столбца {srarf3}  ");
 Console.WriteLine($"cреднее арeфметическое 4го столбца {srarf4}  ");