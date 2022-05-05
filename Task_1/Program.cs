// 1. Напишите программу, которая на вход принимает два числа и
// проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да
// 2. Напишите программу, которая будет выдавать название дня
// недели по заданному номеру.


Console.WriteLine("Введите число 1 ->");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ->");
int num2 = int.Parse(Console.ReadLine());
bool result = num2 * num2 == num1;
Console.WriteLine(result ? "Yes"  :  "No");
