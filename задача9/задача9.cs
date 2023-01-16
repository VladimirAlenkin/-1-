Console.WriteLine("Задача 9: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа");
int numberN = new Random().Next(10, 100);
int numberA = numberN%10;
int numberB = (numberN - numberA)/10;
if (numberA > numberB)
{ 
    Console.Write("Наибольшая цифра числа: ");
    Console.WriteLine(numberN); 
    Console.WriteLine(numberA); 
}
else
{
    Console.Write("Наибольшая цифра числа: ");
    Console.WriteLine(numberN); 
    Console.WriteLine(numberB); 
}
