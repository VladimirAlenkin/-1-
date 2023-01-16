Console.WriteLine("Задача 10: удалить вторую цифру трёхзначного числа");
Console.WriteLine("введите трёхзначное число");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberA = numberN%10; // третья цифра
int numberB = (numberN - numberN%100)/10;//первая цифра*10
int numberC = numberB + numberA;
Console.Write(numberC); 