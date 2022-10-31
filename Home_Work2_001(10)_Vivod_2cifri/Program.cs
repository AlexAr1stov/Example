// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите число: ");
int number = int.Parse (Console.ReadLine());
if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
int Two = Math.Abs(number) / 10 % 10;
Console.WriteLine($"Вторая цифра числа {number} равна {Two}");
}
else
{
    Console.WriteLine("Введено не трёхзначное число!");
}
