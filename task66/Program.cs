// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumber (int m, int n)
{
    if (m > n) return 0;
    return m + SumNaturalNumber (m + 1, n);
}
Console.WriteLine(SumNaturalNumber (1, 15) );