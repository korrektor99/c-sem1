// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
int sum=0;
int rec(int n,int i)
{
    if (n<=i)
    {
        sum+=n;
        return rec(n+1,i);
    }
    return 1;
    
}

rec(N,M);
    Console.WriteLine(sum);