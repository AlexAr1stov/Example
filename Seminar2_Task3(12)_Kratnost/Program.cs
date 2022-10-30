// 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите 1 число: ");
int NumberOne = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int NumberTwo = int.Parse(Console.ReadLine());
if (NumberOne ==0)
{
    Console.WriteLine("Ошибка, введен 0");
    return;
}

int ostatok = NumberTwo % NumberOne;
if (ostatok == 0)
{
    Console.WriteLine($"{NumberTwo}, {NumberOne}-> кратно ");
}
else
{
    Console.WriteLine($"{NumberTwo}, {NumberOne}-> не кратно, остаток {ostatok} ");
}
