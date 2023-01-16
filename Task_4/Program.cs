//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int count = 2;

Console.WriteLine($"Четные числа от 1 до {number}");

while (count <= number)
{
Console.WriteLine($"{count}");
count=count+2;
}