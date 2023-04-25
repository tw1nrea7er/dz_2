// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());

 if (day == 7 || day == 6)
    {
        Console.WriteLine("выходной день! Отдыхыйте");
    }
    else if (day > 0 && day < 6)
    {
        Console.WriteLine("Ержан, на работу пора!");
    }
    else 
    {
        Console.WriteLine("такого дня нет");
    }