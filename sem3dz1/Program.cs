//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите 5-х значное число");
int x = int.Parse(Console.ReadLine()) ;
if(x/10000==x%10)
{
    if(x/1000==x%100)
    {
        Console.WriteLine($" число {x}-палиндром");
    }
    else
    {
        Console.WriteLine($" число {x}- не палиндром");
    }
}
else
{
    Console.WriteLine($" число {x}- не палиндром");
}