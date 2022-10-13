int countNumber = 3, 
    counter = 1;
int? max = null,
    number = null;

while (counter <= countNumber)
{
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    
    if (max == null) max = number;
    if (max < number) max = number;

    counter ++;
}

Console.WriteLine($"Максимальное значение {max}");