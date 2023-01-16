// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа:");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);
int max=0;
if (number1 >= max)
{
max = number1;    
}
if (number2 >= max)
{
max = number2;    
}
if (number3 >= max)
{
max = number3;    
}
Console.WriteLine($"Наибольшее число: {max}");





