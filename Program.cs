/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m, n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out n);

Console.WriteLine(Fibb(n));

int Fibb(int item)
{
    if (item < 0)
        return -1;
    if (item == m)
        return m;
    if (item == 1)
        return 1;
    return item + Fibb(item - 1);
}