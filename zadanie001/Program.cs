﻿//Задание 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if ( b * b == a )
Console.WriteLine("Первое число является квадратом второго числа");

else 
Console.WriteLine("Первое число не является квадратом второго числа");

Console.WriteLine();