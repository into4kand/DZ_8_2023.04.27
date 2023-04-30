// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1 || a > 7)
{
    Console.WriteLine("Try again ");
}
else if (a > 0 & a < 6)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Yes");
}