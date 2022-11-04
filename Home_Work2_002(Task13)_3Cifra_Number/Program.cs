// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int Three=0;
int AbsNumber=Math.Abs(number);
if (AbsNumber < 100)
{
    Console.WriteLine($"В числе {number} третьей цифры нет");
}
else 
if (AbsNumber >= 100)
{
    while (AbsNumber > 1000)
    {
    AbsNumber = AbsNumber/ 10;
    }
    Three = AbsNumber % 10;
    Console.WriteLine($"В числе третья цифра {Three}");
}
