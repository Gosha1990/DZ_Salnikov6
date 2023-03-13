// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: N ");
int N = Convert.ToInt32(Console.ReadLine());

/// <summary>
/// Печатает последовательность натуральных чисел от N до 1
/// </summary>
/// <param name="start">M</param>
/// <param name="end">N</param>
/// <returns></returns>
 string PrintNumbers(int start, int end)
{
    //Базовый 
    if (start == end) return start.ToString();
    // Рекурсивный 
    return (start + "," + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M,N));