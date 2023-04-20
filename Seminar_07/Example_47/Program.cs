// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Метод для запрашивания ввода в консоли пользователя и сохранени ввода в тип int
int GetNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод заполнения двумерного массива случайными числами
double[,] FillArray(int row, int columns)
{

    double[,] arrayOfRealNumbers = new double[row, columns];

    for (int i = 0; i < arrayOfRealNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOfRealNumbers.GetLength(1); j++)
        {
            // число получается в резльтате перемножения рандомного числа типа double (от 0 до 1) на рандомное целое число от -10 до 9
            arrayOfRealNumbers[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 10), 1);
        }
    }
    return arrayOfRealNumbers;
}

// Метод вывода на печать массива
void PrintArray(double[,] Number)
{

    for (int i = 0; i < Number.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < Number.GetLength(1); j++)
        {
            Console.Write($"{Number[i, j]} ");
        //    описаны условия для вывода пробелов перед знаком "|", чтобы был красивый вывод таблицы
            if (Number[i, j] - Math.Round(Number[i, j], 0) == 0 & Number[i, j] >= 0)
            { 
                Console.Write("   | "); // три пробела
            }

            else if (Number[i, j] - Math.Round(Number[i, j], 0) == 0 & Number[i, j] < 0)
            {
                Console.Write("  | "); // два пробела
            }
            else if (Number[i, j] - Math.Round(Number[i, j], 0) != 0 & Number[i, j] < 0)
            {
                Console.Write("| "); // ноль пробелов
            }
            else if (Number[i, j] - Math.Round(Number[i, j], 0) != 0 & Number[i, j] > 0)
            {
                Console.Write(" | "); // один пробел
            }
        }
        Console.WriteLine();
    }

}

int row = GetNumber("Введите количество строк для таблицы вещественных чисел: ");
int columns = GetNumber("Введите количество столбцов для таблицы вещественных чисел: ");
double[,] resultArray = FillArray(row, columns);
PrintArray(resultArray);


