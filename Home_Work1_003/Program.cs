// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет

Console.WriteLine("введите число");
int Number = int.Parse (Console.ReadLine());
if (Number % 2 == 0 )
{
    Console.WriteLine ("Введенное число " + Number +  " четное");
}
else
{
    Console.WriteLine ("Введенное число " + Number +  " нечетное");
}