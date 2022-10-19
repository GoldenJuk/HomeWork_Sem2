// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите любое число: ");
Console.WriteLine();

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Используем Abs на случай, если пользователь введет отрицательное число.  

number = Math.Abs(number);

if (number < 100)
    {
    Console.WriteLine("Третьей цифры в этом числе нет");
    Console.WriteLine();
    }
else
    {
    while (number >  999)
        {
        number = number / 10;
        }
    int a = number % 10;
    Console.WriteLine($"Третья цифра введенного числa - это  " + a);
    Console.WriteLine();
    }
