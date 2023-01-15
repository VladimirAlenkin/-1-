Console.WriteLine("Задача 3: по заданному номеру дня недели вывести его название");
Console.WriteLine("введите число от 1 до 7");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay == 1)
{
    Console.WriteLine("Понедельник");
}
else
{
    if (numberDay == 2)
    {
        Console.WriteLine("Вторник");
    }
    else
    {
        if (numberDay == 3)
        {
           Console.WriteLine("Среда");
        }
        else
        {
            if (numberDay == 4)
            { 
                Console.WriteLine("Четверг");
            }
            else
            {
                if (numberDay == 5)
                { 
                    Console.WriteLine("Пятница");
                }
                else
                {
                    if (numberDay == 6)
                    {
                        Console.WriteLine("Суббота");
                    }
                    else
                    {
                        if (numberDay == 7)
                        {
                            Console.WriteLine("Воскресенье");
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели некорректное число");
                        }
                    }
                }
            }

        }
    }
}