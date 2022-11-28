// Напигите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа
int n = ReadInt("Введите трехзначное число: ");
int amount = n.ToString().Length;
{
    Console.WriteLine(InCenter(n));
}

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}

// Проверено на 456, 678, 918