// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Метод заполнения массива
void FillArray(int[] Number)
{

    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1, 99);
    }
}

// Метод вывода на печать массива
void PrintArray(int[] Number)
{
    Console.Write("[");
    for (int i = 0; i < Number.Length; i++)
    {
        Console.Write($"{Number[i]}");

        if (i < Number.Length - 1) Console.Write(", ");
        else Console.Write("");
    }
    Console.WriteLine("]");
    //Console.WriteLine();
}

// Метод поиска минимального элемента

int MinElementArray(int[] Number)
{
    int min = 0;

    int minPosition = 0;

    for (int i = 1; i < Number.Length; i++)
    {
        if (Number[i] < Number[minPosition]) minPosition = i;
        min = Number[minPosition];

    }

    return min;
}

// Метод поиска максимального элемента
int MaxElementArray(int[] Number)
{
    int max = 0;

    int maxPosition = 0;

    for (int j = 1; j < Number.Length; j++)
    {
        if (Number[j] > Number[maxPosition]) maxPosition = j;
        max = Number[maxPosition];

    }

    return max;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);

int resultMin = MinElementArray(array);
Console.WriteLine($"Минимальный элемент массива: {resultMin}");

int resultMax = MaxElementArray(array);
Console.WriteLine($"Максимальный элемент массива: {resultMax}");

int result = resultMax - resultMin;
Console.WriteLine($"Разность между Максимальным и Минимальным элементами массива: {result}");



