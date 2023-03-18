//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int NumberThree = Convert.ToInt32(Console.ReadLine());

int max = NumberOne;

if (NumberOne >= max)
    {
        max = NumberOne;
    }
    if (NumberTwo > max)
    {
        max = NumberTwo;
    }
    if (NumberThree > max)
    {
        max = NumberThree;
    }

Console.WriteLine($"max = {max}");

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22