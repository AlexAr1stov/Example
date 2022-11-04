// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);

int resultNumbersOddIndex = 0;
Console.WriteLine("Cумма элементов стоящих на нечетных позициях:");
for (int i = 1; i < numbers.Length; i += 2)
{
    resultNumbersOddIndex += numbers[i];
}
Console.Write(resultNumbersOddIndex);



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
