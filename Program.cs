// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Count(int size)
{
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter a number: ");
        int user = Convert.ToInt32(Console.ReadLine());
        if(user > 0) count++;
    }
    Console.WriteLine($"Количество положительных чисел = {count}");
}
Console.WriteLine("Enter a count of numbers: ");
int length = Convert.ToInt32(Console.ReadLine());

Count(length);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Point(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    Console.WriteLine($"Точка пересечения: {x}");
}

Console.WriteLine("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Point(b1, k1, b2, k2);