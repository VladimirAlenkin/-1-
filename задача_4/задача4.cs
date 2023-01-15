Console.WriteLine("Задача 4: найти максимальное из трех чисел");
Console.Write("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.Write("Максимальное число - первое: ");
        Console.Write(numberA);
    }
    else
    {
        Console.Write("Максимальное число - третье: ");
        Console.Write(numberC);
    }
}
else
{
    if (numberB > numberC)
    {
        Console.Write("Максимальное число - второе: ");
        Console.Write(numberB);
    }
    else
    {
        Console.Write("Максимальное число - третье: ");
        Console.Write(numberC);
    }
}