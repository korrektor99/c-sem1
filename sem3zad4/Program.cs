// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
Console.WriteLine("Введите число N");
double r = int.Parse(Console.ReadLine()) ;  
double S= (3.14*Math.Pow(r,2));
int f= Convert.ToInt32(S);
Console.WriteLine($"{f}");
int max = 0;
while(f/10!=0)
{
    if(f%10>max)
    {
        max=f%10;
        
    }
    f=f/10;
}
Console.WriteLine($"{max}");