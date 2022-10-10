// Найти третью цифру числа или сообщить, что её нет
// Халтура... на третьем часе моя сдулась. третью цифру справа определю по накатанной.

int Number = new Random().Next(1, 9999);
Console.WriteLine();
Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) Console.WriteLine($"Третья с конца цифра числа {Number} является {Number / 100 % 10}");
else Console.WriteLine($"{Number} третья цифра отсутствует");

Console.WriteLine();

