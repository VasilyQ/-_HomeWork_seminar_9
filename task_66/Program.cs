// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 4;
int n = 8;

int SumValueRecursion(int start, int end)
{
    if(end == start) return start;
    int sum = SumValueRecursion(start, end-1) + end;
    return sum;
}
Console.WriteLine(SumValueRecursion(m, n));
