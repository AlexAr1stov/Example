// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int NumberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberTwo = int.Parse(Console.ReadLine());
if (NumberOne == NumberTwo)
    {
    Console.WriteLine("Введеные числа равны");
    }
if (NumberOne > NumberTwo)
    {
        Console.WriteLine("Максимальное число первое. Равное " + NumberOne + " Миниальное число второе. Равное " + NumberTwo);
    }
else
if (NumberOne < NumberTwo)
    {
    Console.WriteLine("Максимальное число второе. Равное " + NumberTwo + " Миниальное число первое. Равное " + NumberOne);
    }