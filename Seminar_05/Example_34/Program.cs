// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод заполнения массива трехзначными числами
void FillPositiveNumber(int[] thirdNumber)
{
    int length = thirdNumber.Length;
    int index = 0;
    while (index < length)
    {
        thirdNumber[index] = new Random().Next(100, 999);
        //index = index + 1;
        index++;
    }
}

// Метод вывода на печать массива с трехзначными числами
void PrintPositiveNumber(int[] thirdNumber)
{
    Console.Write("[");
    for (int i = 0; i < thirdNumber.Length; i++)
    {
        Console.Write($"{thirdNumber[i]}");
        if (i < thirdNumber.Length - 1) Console.Write(", ");
        else Console.Write("");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Метод определения количества четных чисел в массиве трехзначных чисел
int EvenNumbersQuantity(int[] thirdNumb)
{
    int quantity = 0;
    for (int i = 0; i < thirdNumb.Length; i++)
    {

        if (thirdNumb[i] % 2 == 0)
        {
            quantity++;
        }

    }
    return quantity;
}

int[] numberMatrix = new int[4];
FillPositiveNumber(numberMatrix);
PrintPositiveNumber(numberMatrix);
int result = EvenNumbersQuantity(numberMatrix);
Console.WriteLine($"Количество четных чисел равно: {result}");
