Console.Clear();
Console.Write("Введите положительное число: ");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    for (int i = 2; i <= N; i++) 
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i} ");
        }
    }
}
else 
    {
        Console.Write("Введено отрицательное значение");
    }