// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int A = new Random().Next(10, 99);
int Max = 0;
int MaxDigit()
{
    int FirstDigit = A / 10;
    int SecondDigit = A % 10;
    if (FirstDigit > SecondDigit) Max = FirstDigit;
    else Max = SecondDigit;
    return Max;
}
MaxDigit();
Console.WriteLine();
Console.WriteLine($"В числе {A} наибольшая цифра {Max}");
Console.WriteLine();
