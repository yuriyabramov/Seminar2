// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 78 -> 8; 12-> 2.

Console.Clear ();

int num = new Random(). Next (10,100);
int a = num / 10;
int b = num % 10;
int max = a;
if (max < b)
{
    max = b;
}
Console.WriteLine($"Максимальнаая цифра в числе {num} -> {max}");

