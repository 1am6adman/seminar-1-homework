// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int x2 = int.Parse(Console.ReadLine());
if (x1 > x2)
    Console.Write("Наибольшим является число 1");
else
    Console.Write("Наибольшим является число 2");