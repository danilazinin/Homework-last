// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());


string Numbers(int n)
{

if ( n % 2 != 0)
{
    n = n - 1;
}
    if (n == 0)
    {
        return " ";
    }
    else
    {
        if (n % 2 == 0)
        {
            return Numbers(n - 1) + n;
        }
        else 
        {
            return " ";
        }
    }

}
Console.WriteLine(Numbers(a));

