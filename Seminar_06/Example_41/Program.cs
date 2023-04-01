// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Метод для запрашивания ввода в консоли пользователя и сохранени ввода в тип int
int GetNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод заполнения массива через ввод элементов из консоли
int[] FillArray(int N)
{

    int[] arrayOfNumbers = new int[N];
    for (int i = 0; i < N; i++)
    {
        arrayOfNumbers[i] = GetNumber($"Введите число № {i + 1}: ");
    }
    return arrayOfNumbers;
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

}

// Метод поиска количества введенных чисел больше нуля
int QuantityNumbersMoreZero(int[] array)
{

    int quantityMoreZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) quantityMoreZero++;
    }
    return quantityMoreZero;
}

int quantityOfInput = GetNumber("Введите количество задаваемых чисел: ");
int[] resultArray = FillArray(quantityOfInput);
PrintArray(resultArray);
Console.WriteLine($"Количество введенных чисел больше 0: {QuantityNumbersMoreZero(resultArray)}");