﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
Console.WriteLine("Вторая цифра это "+b[1]);

