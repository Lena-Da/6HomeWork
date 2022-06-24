// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Введи b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введи k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;


Console.WriteLine($"Прямые пересекаются в точке: ({x}, {y})");
