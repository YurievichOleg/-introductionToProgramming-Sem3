// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

void maxValue ()
{
    int value = new Random().Next(10, 100);
    Console.WriteLine(value);
    int numberA = value/10;
    Console.WriteLine(numberA);
    int numberB = value%10;
    Console.WriteLine(numberB);
    if (numberA > numberB)
    {
        Console.WriteLine($"Наибольшая цифра числа {numberA}");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра числа {numberB}");
    }
    
}
maxValue();