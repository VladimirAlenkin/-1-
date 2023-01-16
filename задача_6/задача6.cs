Console.WriteLine("Задача 6: показать четные числа от 1 до N");
Console.WriteLine("введите число  N");
int N = Convert.ToInt32(Console.ReadLine());
int A = 0;
if (N > 1)
{
    Console.WriteLine("Чётные числа: ");
    while (A < (N -1))
    { 
        A = A +2;
        Console.WriteLine(A);
    }
}
else
{
  Console.WriteLine("Вы ввели некорректное число"); 
}
