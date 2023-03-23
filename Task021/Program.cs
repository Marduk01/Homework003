// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату первого X : ");
int y1 = ReadInt("Введите координату первого Y : ");
int z1 = ReadInt("Введите координату первого Z : ");
int x2 = ReadInt("Введите координату второго X : ");
int y2 = ReadInt("Введите координату второго Y : ");
int z2 = ReadInt("Введите координату второго Z : ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка : {length}");

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}