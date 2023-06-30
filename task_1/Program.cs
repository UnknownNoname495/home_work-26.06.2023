// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 1000)
{
    Console.Write("Введите трёхзначное число.");
    return;
}

int result = (number / 10) % 10;
Console.WriteLine($"В числе {number} вторая цифра -> {result}");
