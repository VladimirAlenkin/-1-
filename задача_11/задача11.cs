Console.WriteLine("Задача 11: выяснить, кратно ли число заданному, если нет, вывести остаток.");
Console.WriteLine("введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = numberA%numberB;
if (numberC != 0)
{
    Console.Write("Остаток от деления: ");
    Console.Write(numberC); 
}
else
{
    Console.Write("Числа кратны.");
}