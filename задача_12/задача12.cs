Console.WriteLine("Задача 12: найти третью цифру числа или сообщить, что её нет");
Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine());
if (A < 100)
{
    Console.WriteLine("Во введенном числе меньше, чем три цифры");
}
else
{
    int B = A; //число для счёта разрядов
    int n = 0;//счётчик разрядов
    int k = 1;//коэффицент
    while (B >= 1 )
        { 
         B = B / 10;
         n = n + 1;
        }
    while (n > 3)
    {
        k = k*10;
        n = n - 1;
    }
    int C = A / k;
    int D = C%10;
    Console.Write("Третья цифра - ");
    Console.Write(D); 
}
