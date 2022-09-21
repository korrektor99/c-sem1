// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()) ;
int chetnie = 2;
while (chetnie<=N)
{
    Console.Write($"{chetnie}, ");
    chetnie+=2;
}



