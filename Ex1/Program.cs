// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{   
    int a = number / 100;
    int b = number / 10;
    int c = (b - a*10);
    Console.Write($"Вторая цифра числа {c}");   
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число ");
}
