/* **Задача 69:** Напишите программу, которая на вход 
принимает два числа A и B, и возводит число А в целую
степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
*/
using System;
using static System.Console;
Clear();

Write("Введите число A - ");
int A=int.Parse(ReadLine());
Write("Введите число B - ");
int B=int.Parse(ReadLine());

WriteLine(degreeA(A,B));

int degreeA (int a, int b)
{
    if (b==0) return 1;
    return a*degreeA(a,--b);
} 