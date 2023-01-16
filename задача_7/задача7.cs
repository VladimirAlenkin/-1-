Console.WriteLine("Задача 7: показать последнюю цифру трёхзначного числа");
Console.WriteLine("введите трёхзначное число");
int numberN = Convert.ToInt32(Console.ReadLine());
if ( numberN > 99 )
{
     if ( 1000 > numberN )
    {
        int numberA = numberN%10;
        Console.Write("последняя цифра - ");
        Console.Write(numberA); 
    }
}
else
{
    Console.Write("Вы ввели некорректное число");
}

