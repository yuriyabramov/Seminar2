// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа, например: 456 -> 46.

int num = new Random(). Next (100,1000);
int a = num / 100 * 10;
int b = num % 10;
int result = a + b;
Console.WriteLine($"{num} -> {result}");