//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите коэфициенты k1 и b1");
double k1 = double.Parse(Console.ReadLine()) ;
double b1 = double.Parse(Console.ReadLine()) ;
Console.WriteLine("Введите коэфициенты k2 и b2");
double k2 = double.Parse(Console.ReadLine()) ;
double b2 = double.Parse(Console.ReadLine()) ;
if(k1==k2&&b1!=b2)
{
    Console.WriteLine("прямые паралельльны");
}
else if(k1==k2&&b1==b2)
{
    Console.WriteLine("прямые совпадают");
}
else 
{
    double x= (b2-b1)/(k1-k2);
   double y=k1*x+b1;
   Console.WriteLine($"{x},{y}");
}


















