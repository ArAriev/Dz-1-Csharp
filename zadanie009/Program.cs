// Удалить вторую цифру трёхзначного числа

int Number = new Random().Next(100, 999);
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();

Console.WriteLine();
Console.WriteLine($"Если удалить из числа {Number} вторую цифру, то останется {NewNumber}");
Console.WriteLine();
