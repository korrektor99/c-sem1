// Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
int rec(int n,int i)
{
    if (n % 2 == 0&&n<i)
    {
        Console.WriteLine($"{n}");
        return rec(n+1,i);
    }
    else
    {
        return rec(n+1,i);
    }
}


    Console.WriteLine(rec(N,M));