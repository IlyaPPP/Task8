/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int n;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

Console.WriteLine(Print(n, 1));

string Print(int n, int i = 1)
{
    if (i >= n)
        return i.ToString();
    return $"{i}, {Print(n, i + 1)}";
}