Console.Clear();
Console.WriteLine("Введите число m");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int b = int.Parse(Console.ReadLine());

int Numbers(int m, int n)
{
   if (m == 0)
   {
    return n + 1;
   }
   if (m > 0 && n == 0 )
   {
     return Numbers(m -1, 1);
   }
   else
   {
    return Numbers((m - 1), Numbers(m, (n -1)));
   }
}

Console.WriteLine($"m = {a}, n = {b} -> A(m,n) = {Numbers(a,b)}");