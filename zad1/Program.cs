Console.WriteLine("ВВедите 1 числo");
int a = int.Parse(Console.ReadLine()) ;
Console.WriteLine("Введите 2ое число");
int b = int.Parse(Console.ReadLine()) ;
int max = 0;
int min = 0;
if(a>b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"max = {max}");
Console.Write($"min = {min}  ");
