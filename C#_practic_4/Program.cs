// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
int i = 1;
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + n);
while (i <= n)
{
     if (i % 2 != 1)
     {
        Console.Write(i + ", ");
    }
        i++;
}
// Проверено на 4,6,8