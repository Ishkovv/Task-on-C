// Задача 10: Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа
int n = ReadInt("Введите трехзначное число: ");
int amount = n.ToString().Length;
{
    Console.WriteLine(InCenter(n));
}

// Сообщение для отображения в консоли, вывод результата введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Вывод цифры стоящей в середине трехзначного числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}

// Проверено на 456, 678, 918
