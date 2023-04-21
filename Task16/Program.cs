// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. Например: 5, 25 -> да; -4, 16 -> да ;25, 5 -> да.

Console.Write("Введите первое число: ");
string a = Console.ReadLine() ?? "";
int b = int.Parse(a);
Console.Write("Введите второе число: ");
string c = Console.ReadLine() ?? "";
int d = int.Parse(c);
if (b * b == d || d * d == b)
{ 
    Console.WriteLine($" {b}, {d} -> да");
}
else Console.WriteLine($" {b}, {d} -> нет");