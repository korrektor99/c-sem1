// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A");
double A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
double B = int.Parse(Console.ReadLine());
double C = Math.Pow(A,B);  
Console.WriteLine($"{C}");
