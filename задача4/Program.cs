Console.Clear();
Console.Write("Введите первое число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число с: ");
int c = int.Parse(Console.ReadLine());
int max = a;

if (b > max)
{
    max = b;
} 
if (c > max)
{
    max = c;
}
Console.Write($"Максимальное число = {max}");