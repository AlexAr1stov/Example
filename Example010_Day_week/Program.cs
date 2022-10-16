// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели");
int NumberWeek = int.Parse(Console.ReadLine());

if (NumberWeek < 1 || NumberWeek > 7) {Console.WriteLine("error");}

switch(NumberWeek)
    {
        case 1:
        Console.WriteLine("Понедельник");
        break;

        case 2:
        Console.WriteLine("Вторник");
        break;

        case 3:
        Console.WriteLine("Среда");
        break;
            
        case 4:
        Console.WriteLine("Четверг");
        break;
    
        case 5:
        Console.WriteLine ("Пятница");
        break;
    
        case 6:
        Console.WriteLine ("Суббота");
        break;
    
        case 7:
        Console.WriteLine("Воскресенье");
        break;
    }
