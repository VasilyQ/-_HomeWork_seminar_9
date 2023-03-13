// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = 8;

void FillRecursion(int number)
{
    Console.Write($"{number} ");
    if(number == 1) return;
    FillRecursion(number -1);
}

FillRecursion(n);