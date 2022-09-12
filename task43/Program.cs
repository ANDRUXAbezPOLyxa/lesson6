// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите значение b1 ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k1 ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2 ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2 ");
double k2 = double.Parse(Console.ReadLine());

double x = -(b1-b2)/(k1-k2);
double y = k2*x+b2;

x = Math.Round(x,3);
y= Math.Round(y,3);

Console.WriteLine ("пересечение прямых в точке: " + x + y);

