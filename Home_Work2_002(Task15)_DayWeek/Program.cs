// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int NumberDay = int.Parse(Console.ReadLine());
if (NumberDay > 0 && NumberDay < 8)
{
    if (NumberDay == 6 || NumberDay == 7)
    {
        Console.WriteLine($"Урра! {NumberDay} день по счету, это выходной день!");
    }
    else 
    if (NumberDay <= 5)
    {
        Console.WriteLine($"{NumberDay} день по счету, это будний день!");
    }
}
else
Console.WriteLine("Укажите корректный день недели! От 1 до 7");