/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double GetNumber(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine().Replace('.', ',');
        if (double.TryParse(num, out double number) == false)
            Console.WriteLine("Введено не число");
        else
            return number;
    }
}



void IntersectionPointLines(double k1, double b1, double k2, double b2)
{

    double y = (-k2 * b1 + k1 * b2) / (k1 - k2);
    double x = (y - b1) / k1;

    Console.WriteLine($"Точка пересечения прямых, заданных уравнениями y = {k1} * x + {b1} , y = {k2} * x + {b2} :({x},{y})");


}
Console.WriteLine("Для прямой y = k1 * x + b1 ");
double k1 = GetNumber("задайте k1: ");
double b1 = GetNumber("задайте b1: ");
Console.WriteLine("Для прямой y = k2 * x + b2 ");
double k2 = GetNumber("задайте k2: ");
double b2 = GetNumber("задайте b2 :");

IntersectionPointLines(k1, b1, k2, b2);