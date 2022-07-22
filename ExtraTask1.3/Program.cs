/*
Задача 3.
На ввод подаётся рост трёх спортсменов.
Расположить их от большего к меньшему.
*/

double a = 2;
double b = 1.7;
double c = 1.9;
Console.WriteLine($"Рост спортсмена №1: {a}");
Console.WriteLine($"Рост спортсмена №2: {b}");
Console.WriteLine($"Рост спортсмена №3: {c}");

if (a > b)
{
    if (b > c)
    {
        Console.WriteLine($"Построение по росту: 1; 2; 3.");
    }
    else if (a > c)
    {
       Console.WriteLine($"Построение по росту: №1; №3; №2.");
    }
    else
    {
            Console.WriteLine($"Построение по росту: №3; №1; №2.");
        }
}
else
{
    if (a > c)
    {
        Console.WriteLine($"Построение по росту: №2; №1; №3.");
    }
    else
    {
        if (b > c)
        {
            Console.WriteLine($"Построение по росту: №2; №3; №1.");
        }
        else
        {
            Console.WriteLine($"Построение по росту: №3, №2, №1.");
        }
    }
}