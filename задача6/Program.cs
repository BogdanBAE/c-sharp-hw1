Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"Число {number} является четным");
} 
else
{
    Console.Write($"Число {number} является НЕ четным");
}