﻿// Console.WriteLine("Введите число");
// int a = new Random().Next(1,10);
// int sqr=a*a;
// Console.WriteLine(sqr);

// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + sqr);