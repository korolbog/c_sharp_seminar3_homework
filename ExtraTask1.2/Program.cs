/*
Задача 2.
Даны два числа a, b,
такие что a < b.
Вывести на экран сколько раз число a поместиться в числе b.
*/

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int quontient = 1;

if (a < b)
{
    quontient = b / a;
    Console.Write($"Число а поместится в число b следующее количество раз: {quontient}");
}
else
{
    Console.Write("Ошибка ввода. Число a должно быть меньше числа b.");
}
