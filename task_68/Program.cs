// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = 3;
int n = 4;
Console.WriteLine(AckermanRecursion(m,n));

int AckermanRecursion(int m, int n)
{
    if(m == 0) return n+1;
    if(m > 0 && n == 0) return AckermanRecursion(m -1, 1);
    return AckermanRecursion(m-1, AckermanRecursion(m, n-1));
}