// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число a");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA>NumberB)
    {
            Console.WriteLine($"Максимум равен = {NumberA}");
    }
else 
    {
            Console.WriteLine($"Максимум равен = {NumberB}");
    }
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

