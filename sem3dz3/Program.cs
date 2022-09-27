// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
double N = int.Parse(Console.ReadLine()) ;  
while (1<=(N))
{
    double tablitsa=Math.Pow((N),3);
    Console.Write($"{tablitsa}, ");
    N+=-1;
}

