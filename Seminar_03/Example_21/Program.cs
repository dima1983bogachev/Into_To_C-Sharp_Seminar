//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Координаты точки А
Console.Write("Введите координаты точки А: X=");
double firstX = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки А: Y=");
double firstY = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки А: Z=");
double firstZ = Convert.ToDouble(Console.ReadLine());

// Координаты точки B
Console.Write("Введите координаты точки B: X=");
double seccondX = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B: Y=");
double seccondY = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B: Z=");
double seccondZ = Convert.ToDouble(Console.ReadLine());

double lengthX= Math.Pow(firstX-seccondX, 2);
double lengthY= Math.Pow(firstY-seccondY, 2);
double lengthZ= Math.Pow(firstZ-seccondZ, 2);


var Result = Math.Sqrt(lengthX+lengthY+lengthZ);

Console.WriteLine("Расстояние межд двумя точками = " + Result);

/*
int[] InterArray(int X, int Y, int Z)
{
    int[] Array;
    for (i = 0; i < 3; i++)
    {
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
*/