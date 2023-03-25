// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine("Введите число:");

string NumberString = Console.ReadLine();
char[] Number = NumberString.ToCharArray();

int Index = Number.Length;
if (Index <= 2)
{
    Console.WriteLine("Третьей цифры числа нет");
}
else
{
    Console.WriteLine($"Третья цифра числа: {Number[2]}");
}

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


/*
int IndexOf(char[] number, int find)
{
    int index = number.Length;
    int count = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    Return position;
}

int ThreeIndex = IndexOf(Number, 2);
*/


