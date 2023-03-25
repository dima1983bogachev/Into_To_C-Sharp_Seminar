/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа*/


Console.WriteLine("Введите трехзначное число:");

string NumberString = Console.ReadLine();

char[] Number = NumberString.ToCharArray();

Console.WriteLine($"Вторая цифра числа: {Number[1]}");



// 456 -> 5
// 782 -> 8
// 918 -> 1
