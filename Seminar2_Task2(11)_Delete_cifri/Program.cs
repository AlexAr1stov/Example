// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.Clear();
int number = new Random().Next(100,1000);
int FirstSymbol = number/100;
int LastSymbol = number%10;
Console.WriteLine($"Число {number} сократилось до {FirstSymbol}{LastSymbol}");

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int Three = num % 10;
// int Two = (num / 10) % 10;
// int One = num / 100;
// int NewNum = One*10+Three;
// Console.WriteLine($"Число без второй цифры {NewNum}");
