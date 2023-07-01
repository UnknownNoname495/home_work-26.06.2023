// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0 || number > 7)
{
    Console.Write("Это не день недели!");
    return;
}

int result = number;
if (result > 0 && result <= 5)
{
    Console.WriteLine("Сегодня будний день...");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Сегодня выходной!");
    }
}
