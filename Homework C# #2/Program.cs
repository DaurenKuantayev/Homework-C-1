// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Напишите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
    Console.WriteLine($"a = {numberA} b = {numberB} c = {numberC} -> max = {max}");
}
else
{
    Console.WriteLine($"a = {numberA} b = {numberB} c = {numberC} -> max = {max}");
}


