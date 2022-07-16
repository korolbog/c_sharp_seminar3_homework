/*
Задача 19. 
Напишите программу,
которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Попытка решить через разворот массива с последующей сортировкой,
но не уменю преобразовывать число в массив.

Console.Write("Введите пятизначное число-палиндром N:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = {N};
int posSwap = 0;
int index = 0;
int temp = 0;
while (index < N/2)
{
    temp = array[posSwap+index];
    array[posSwap+index] = array[N-1-index];
    array[N-1-index] = temp;
}
Console.WriteLine(array);
int N = new Random().Next(10000, 100000);
*/
Console.Write("Введите пятизначное число-палиндром N:");
int N = Convert.ToInt32(Console.ReadLine());
int dividend = N;
int result = 0;
int i = 0;
int remainder = 0;
int quontient = 0;
string interim = "";
while (i < 5)
{
    remainder = dividend % 10;
    interim = $"{interim}{remainder}";
    quontient = dividend / 10;
    dividend = quontient;
    i++;
}
result = Convert.ToInt32(interim);
if (result == N)
{
    Console.WriteLine($"Да, число {N} - палиндром.");
}
else
{
    Console.WriteLine($"Нет, число {N} не палиндром.");
}
