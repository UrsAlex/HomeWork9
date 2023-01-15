// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int GetSum (int m, int n)
{
    if (m == n) return n;
    else return m + GetSum(m + 1, n);
}

int m = GetNumber("Введите первое число:");
int n = GetNumber("Введите второе число:");

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {GetSum(m, n)}");