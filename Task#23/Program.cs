﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Input : ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= n; i++)
   {
   Console.WriteLine($"=>{Math.Pow(i,3)}");
   }






