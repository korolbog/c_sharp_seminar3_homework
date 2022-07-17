﻿/*
Задача 23
Напишите программу,
которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
string result = "";
int interimResult = 0;

while (i <= N)
{
    interimResult = i * i * i;
    result = $"{result}{interimResult}, ";
    i++;
}
Console.WriteLine(result.Remove(result.Length-2, 2));