// Выяснить является ли число чётным

Console.WriteLine("введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0) 
Console.WriteLine($"число {n} четное число");

else 
Console.WriteLine($"число {n} не четное число");
