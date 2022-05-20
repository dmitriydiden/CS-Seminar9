/*Задача 67:** Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
using System;
using static System.Console;
Clear();
Write("Введите число М - ");
int M=int.Parse(ReadLine());

int sum = 0;
SumNumber(M);
WriteLine(sum);

int SumNumber(int num)
{
    if (num == 0) return sum;
    else
    {
        sum += num % 10;
        return SumNumber(num/=10);
    }
}