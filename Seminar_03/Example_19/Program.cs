//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите 5-ти значное число");
string NumberString = Console.ReadLine();
// Перевод числа из строки в массив символов
char[] Number = NumberString.ToCharArray();
// метод вывода массива 
void PrintArray(char[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

//Метода реверса массива
void ReverseArray(char[] array)
{
    for (int i = 0; i < array.Length - i - 1; i++)
    {
        char temporary = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temporary;
    }
}

// PrintArray(Number);

char[] reversedNumber = Number;
ReverseArray(reversedNumber);
PrintArray(reversedNumber);


if (reversedNumber == Number) Console.WriteLine("Да, это палиндром");
else Console.WriteLine("Нет, это не палиндром");

