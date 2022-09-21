// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int v = x;
if (x / 100 > 0)
{
    while (v / 1000 != 0)
        {
            v=v/10;
        }
    int b = v%10;
    Console.WriteLine($"3ая цифра в числе {x} = {b}");
}
else
{
    Console.WriteLine($"число {x} двухзначное, следовательно третьей цифры нет");
}
