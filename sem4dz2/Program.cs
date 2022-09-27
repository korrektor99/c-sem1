//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()) ;  
int Sum = 0;
while(N!=0)
{
    
    
    Sum=N%10+Sum;
    N=N/10;
}
Console.WriteLine($"{Sum}");