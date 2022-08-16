// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Input : ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;

for(; i <= n; i++)
{
   Console.WriteLine($"=>{Math.Pow((i), 3)}");
}
for(i=-1; i >= n; i--)
{
   Console.WriteLine($"=> - {Math.Pow(-i, 3)}");
}
if(n == 0)
{
   Console.WriteLine("Incorrect number");
}

