// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Метод заполнения массива
void FillArray(int[] Number)
{

    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(-100, 99);
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
    Console.Write("] -> ");
    //Console.WriteLine();
}

// Метод определения суммы элементов с четными позициями массива (нумерация начинается с 1)
int EvenNumbersSum(int[] thirdNumb)
{
    int sum = 0;
    for (int i = 0; i < thirdNumb.Length; i++)
    {

        if ((i+1) % 2 == 0)
        {
            sum +=thirdNumb[i];
        }

    }
    return sum;
}



int[] numberMatrix = new int[4];
FillArray(numberMatrix);
PrintArray(numberMatrix);

int result = EvenNumbersSum(numberMatrix);
Console.WriteLine($"Сумма чисел на четных позициях равна: {result}");