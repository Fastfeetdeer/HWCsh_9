// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Инициализация программы");

bool inWork = true;
while (inWork)
{
    Console.Write("Выбери задачу: ");
    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Task_1(); 
                break;
                }
            case 2:
                {
                    Task_2(); 
                break;
                }
            case 3:
                {
                    Task_3(); 
                break;
                }
            case -1: inWork = false; break;
        }
    }
}

void Task_1()
{
    EntNumb(ReadInt("Введите число:"));
}

void Task_2()
{
    Console.WriteLine($"Сумма чисел = {SumMToN(ReadInt("Введите M:"), ReadInt("Введите N:"))}");
}

void Task_3()
{
    Console.WriteLine($"Функция Акермана = {AckermanFunct(ReadInt("Введите M:"), ReadInt("Введите N:"))}");
}

int ReadInt(string argName)
{
    Console.Write($" {argName} ");
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не число! Введите число!!!");
    }
    return number;
}

void EntNumb(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        EntNumb(number - 1);
    }
    else if ((number == 1))
    {
        Console.Write($"{number}");
    }
}

int SumMToN(int m, int n)
{
    if (m <= n)
    {
        return m + SumMToN(m + 1, n);
    }
    return 0;
}

int AckermanFunct(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m != 0)
    {
        return AckermanFunct(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AckermanFunct(m - 1, AckermanFunct(m, n - 1));
    }
    return AckermanFunct(m, n);
}

Console.WriteLine("Программа завершила работу");