/*
Задача 1. Пользователь вводит число N (N > 0).
Программа должна вывести N единиц на экран.
N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1
*/

Console.Write("Введите целое положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int increment = 1;
string result = "1, ";

if (N>0)
{
    if (N<10001)
    {
        for (int i = 1; i < N; i++)
{
    result = ($"{result}{increment}, ");
}
Console.Write(result.Remove(result.Length-2, 2));
    }
    else
    {
        Console.Write("Число, конечно, правильное, но ленно считать. Задайте-ка число поменьше.");
    }
}
else
{
    Console.Write("Введено неправильное число.");
}