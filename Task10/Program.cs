/*  Программа, которая принимает на вход 
 *  трёхзначное число и на выходе показывает 
 *  вторую цифру этого числа.
 */

Console.Clear();
Console.WriteLine("Введите любое трехзначное число: ");
Console.WriteLine();

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Используем Abs на случай, если пользователь введет отрицательное число.  

a = Math.Abs(a);

if (a < 99 || a > 999) 
    {
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз");
    Console.WriteLine();
    }
else
    {
    a = a % 100 / 10;
    Console.WriteLine($"Вторая цифра введенного числa - это  " + a);
    Console.WriteLine();
    }    