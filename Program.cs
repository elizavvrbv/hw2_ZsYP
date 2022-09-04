// Задача 10
System.Console.WriteLine("Задача 10");
System.Console.WriteLine("Введите техзначное число");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Число: {(num1 / 10) % 10}");

// Задача 13
System.Console.WriteLine("Задача 13");
System.Console.WriteLine("ВВедите число");
int num2 = int.Parse(Console.ReadLine());
if (num2 < 100)
{ 
    System.Console.WriteLine($"Третьей цифры нет");
} 
else if (num2 < 1000)
{ 
    System.Console.WriteLine($"Третья цифра {num2 % 10}");
}
else if (num2 > 99)
{
    do
    {
        num2 = (num2 / 10);

    }
    while (num2 > 999);
    System.Console.WriteLine($"Третья цифра {num2 % 10}");
}

// Задание 15
System.Console.WriteLine("Задание 15");
System.Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
if ((day == 7) || (day == 6))
{
    System.Console.WriteLine($"Выходной день");
}
else {
    System.Console.WriteLine($"Рабочий день");
}