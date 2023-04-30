// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
    {
        number /=10;
    }
if (number > 99)
{
    int a = number % 10;
    Console.WriteLine($"Третья цифра в числе это {a}");
}
else
{
    Console.WriteLine("В числе нет третьей цифры ");
}
