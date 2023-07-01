// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("Введите трёхзначное число.");
    return;
}

int result = number;
while (result > 999)
{
    result /= 10; 
}
result = result % 10;
Console.WriteLine($"В числе {number} третья цифра -> {result}");