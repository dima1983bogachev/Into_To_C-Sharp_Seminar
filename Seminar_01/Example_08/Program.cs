//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int i = 1;
Console.Write($"Четные числа от 1 до {Number}: ");

while (i <= Number) 
{
    if ((i % 2) == 0) // Остаток от деления равен нулю
    {
 Console.Write($"{i}, ");
    }
    i++;
}
Console.WriteLine();

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
