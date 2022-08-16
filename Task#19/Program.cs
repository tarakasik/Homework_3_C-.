// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Input fifth digits number: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num /10 %10;
int num5 = num % 10;

if(num < 10000 || num > 99999)
{
   Console.WriteLine("Incorrect number!");
}
else if(num1 == num5 && num2 == num4)
{
   Console.WriteLine("Number is palindrom!");
}
else 
{
    Console.WriteLine("Not palindrom!");
}