Console.WriteLine("Задача 8: показать вторую цифру трёхзначного числа");
Console.WriteLine("введите трёхзначное число");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberA = numberN%10;
int numberB = (numberN - numberA)/10;
int numberC = numberB%10;
Console.Write("вторая цифра - ");
Console.Write(numberC); 