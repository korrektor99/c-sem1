//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел в массиве");
int M = int.Parse(Console.ReadLine()) ;
int[] array= new int[M];
int count=0;
for(int y=0;y<M;y++)
{
    Console.WriteLine("Введите число");
    array[y]=int.Parse(Console.ReadLine());
    if (array[y]>0)                  
    {
        count++;
    }
}
void printarray (int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        Console.WriteLine("A[{0}]={1}",i, arr[i]);
    }
}
printarray(array);
    Console.WriteLine($"колличество элементов больше 0 = {count}");
