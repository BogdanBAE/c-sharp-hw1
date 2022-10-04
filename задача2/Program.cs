Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write($"Max = {firstNumber} MIN =  {secondNumber}");
} 
else
{
    Console.Write($"Max = {secondNumber} MIN =  {firstNumber}");
}