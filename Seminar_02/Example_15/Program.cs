// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели (от 1 до 7):");

int NumberOfDay = Convert.ToInt32(Console.ReadLine());

if (NumberOfDay <= 5)
{
    Console.WriteLine("Нет");
    Console.WriteLine("Этот день недели - рабочий");
}
else
{
     Console.WriteLine("Да");
    Console.WriteLine("Этот день недели - выходной");
}


// 6 -> да
// 7 -> да
// 1 -> нет
