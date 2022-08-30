// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число для k1: ");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите число для k2:  ");
double k2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите число для b1:  ");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите число для b2:  ");
double b2 = Double.Parse(Console.ReadLine());

Console.WriteLine($"Точка пересечения прямых: {CrossPoint(k1,k2,b1,b2)}");


string CrossPoint(double k1, double k2, double b1, double b2)
{
    var x=(b2-b1)/(k1-k2);  
    var y=(k1*(b2-b1))/(k1-k2)+b1;
    return $"x: {x} y: {y}";
}