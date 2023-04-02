// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Double GetInputNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

(double b, double k) GetCoefficient()
{
    double b = GetInputNumber("Введите значение коэффициента b: ");
    double k = GetInputNumber("Введите значение коэффициента k: ");
    return (b, k);
}

double[] GetPointOfIntersection((double b, double k) line1, (double b, double k) line2)
{
    double[] pointOfIntersction = new double[2];
    pointOfIntersction[0] = Math.Round((line1.b - line2.b) / (line2.k - line1.k), 2);
    pointOfIntersction[1] = Math.Round(line2.k * ((line1.b - line2.b) / (line2.k - line1.k)) + line2.b, 2);
    return pointOfIntersction;
}

void PrintArray(double[] Number)
{
    Console.Write("[");
    for (int i = 0; i < Number.Length; i++)
    {
        Console.Write($"{Number[i]}");

        if (i < Number.Length - 1) Console.Write("; ");
        else Console.Write("");
    }
    Console.WriteLine("]");
}
Console.WriteLine("-- Ввод коэффициентов уравнения прямой 1 --");
(double b, double k) line1 = GetCoefficient();
Console.WriteLine("-- Ввод коэффициентов уравнения прямой 2 --");
(double b, double k) line2 = GetCoefficient();

double[] result = GetPointOfIntersection(line1, line2);

Console.WriteLine($"Точка пересечения прямой y={line1.k}*x+{line1.b} с прямой y={line2.k}*x+{line2.b} в формате [x, y]:");
PrintArray(result);
//Console.WriteLine($"[x, y] = {PrintArray(result)}");