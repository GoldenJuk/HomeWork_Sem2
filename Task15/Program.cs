// Программа, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
Console.WriteLine();
int nubmber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (nubmber < 1 || nubmber > 7)
    {
    Console.WriteLine("Попрубуйте еще раз. Цифры должны быть от 1 до 7");
    Console.WriteLine();
    }
else
{
    if (nubmber == 6 || nubmber == 7)
        {
        Console.WriteLine("Этот день недели - выходной!");
        Console.WriteLine();
        }
    else
        {
        Console.WriteLine("Этот день недели - не выходной");
        Console.WriteLine();
        }
}