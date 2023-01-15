Console.WriteLine("Задача 2: по двум заданным числам проверять является ли первое квадратом второго");
Console.Write("введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = numberB*numberB;
if (numberA == numberC)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
