Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 1)
{
    int nowNumber = 2;
    while (nowNumber <= number)
    {
        Console.Write($"{nowNumber} ");
        nowNumber += 2;
    }
}
else
{
    Console.Write("Четных чисел нет");
}