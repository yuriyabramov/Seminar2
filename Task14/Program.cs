// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23, например: 14 -> нет; 46 -> нет.

int varA;
while(true)
{
    Console.Write("Введите число: ");
    if(int.TryParse(Console.ReadLine(), out varA))
    break;
    Console.WriteLine("false");
}
if(varA % 7 == 0 && varA % 23 == 0)
{
    Console.WriteLine($"{varA} -> ДА");
}
else
{
    Console.WriteLine($"{varA} -> НЕТ");
}