//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Перевод числа из строки в тип int
Console.WriteLine("Введите число");
string NumberString = Console.ReadLine();
int Number = Convert.ToInt32(NumberString);

// Строка преобразуется в массив символов, чтоб определить количество разрядов числа по максимальной длине массива
char[] NumberIndex = NumberString.ToCharArray();

int result = 0;

for (int i = NumberIndex.Length; i >= 0; i--)
{
    result += Number / (int)Math.Pow(10, i);
    Number = Number % (int)Math.Pow(10, i);
}
Console.WriteLine(result);

