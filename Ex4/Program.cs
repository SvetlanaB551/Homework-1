// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задание №4");
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = N - 1;

while (count > 1)
{
    if (count % 2 == 0)

        Console.WriteLine(count);
        count = count - 1;
    

}
Console.WriteLine("Конец");