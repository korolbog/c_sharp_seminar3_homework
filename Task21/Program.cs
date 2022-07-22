/*
Задача 21
Напишите программу,
которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int Ax = 3;
int Ay = 6;
int Az = 8;
int Bx = 2;
int By = 1;
int Bz = -7;
double distanceAB = Math.Pow((Math.Pow(Bx - Ax, 2))+(Math.Pow(By - Ay, 2))+(Math.Pow(Bz - Az, 2)), 0.5);
double result = Math.Round(distanceAB, 2);
Console.WriteLine(result);