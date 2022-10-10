// Показать последнюю цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Последней цифрой трехзначного число {number} будет цифра {number % 10}");
