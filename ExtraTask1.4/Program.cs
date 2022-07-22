/*
Задача 4.
Дано N секунд.
Вывести время в формате часы:минуты:секунды.
N = 72334 -> 20:5:34 
*/
int N = 72334;
int seconds = N % 60;
int minutes = N / 60; 
int hours = 0;
string result = string.Empty;

if (minutes < 60)
{
    result = $"{hours}:{minutes}:{seconds}";
}
else
{
    hours = minutes / 60;
    minutes = minutes % 60;
    result = $"{hours}:{minutes}:{seconds}";
}
Console.WriteLine(result);