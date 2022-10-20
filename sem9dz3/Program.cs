// Задайте значения M и N. Напишите программу, которая 
//найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
int maxNOD = 0;

int rec(int i)
{

    if (N % i == 0 && M % i == 0 && i <= N && i <= M)
    {
        if (i > maxNOD)
        {
            maxNOD = i;
        }
        return rec(i+1);
    }
   if (i>N||i>M)
   {
    return 1;
   }
   return rec(i+1);

}

rec(1);
Console.WriteLine($"НОД {N} и {M} = {maxNOD}");