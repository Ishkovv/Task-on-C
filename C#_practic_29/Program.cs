// Напишите программу, которая задаёт массив из 8 элементов, запрашивает данные (элементы массива) у пользователя и выводит их на экран.

Console.Write("Введите 8 элементов через запятую: ");

string[] elements = Console.ReadLine().Split(',');

Console.WriteLine($"[{string.Join(", ", elements)}]");

Console.ReadLine();

// Проверено на 1, 2, 5, 7, 19, 6, 1, 33. 