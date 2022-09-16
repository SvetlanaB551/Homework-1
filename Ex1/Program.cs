// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задание №1");
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if (a > b)

Console.WriteLine("max = " + a);

else if (a < b)
{
    Console.WriteLine("max =" + b);
}
else if (a == b)
{
    Console.WriteLine("a = b");
}