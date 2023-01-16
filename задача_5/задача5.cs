Console.WriteLine("Задача 5: выяснить является ли число чётным");
Console.WriteLine("введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA%2 > 0)
{
    Console.Write("Число не является чётным ");
}
else
{
    Console.Write("Число является чётным ");
}
