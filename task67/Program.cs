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

int sum = SumNumber(M);
WriteLine(sum);

static int SumNumber(int num)
{
    if (num == 0) return 0;
    else
    {
       return num%10+SumNumber(num/=10);
    }
}