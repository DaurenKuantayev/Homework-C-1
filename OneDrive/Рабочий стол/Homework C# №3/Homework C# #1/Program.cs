// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
void DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int FirstPartNumb = number / 100 ;
    int SecondPartNumb = number % 1000;
    if (FirstPartNumb == SecondPartNumb)
    {
        Console.Write($"{number} -> да");
    }
    else
    {
        Console.Write($"{number} -> нет");
        Console.Write($"{FirstPartNumb} {SecondPartNumb}");
    }
    Console.WriteLine();
}

DataEntry("Введите пятизначное число: ");