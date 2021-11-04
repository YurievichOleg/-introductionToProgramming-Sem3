// 14. Найти третью цифру числа или сообщить, что её нет

void threeValue ()
{
    int value = new Random().Next(10, 9999);
    Console.WriteLine(value);
    if (value > 99)
    {
        Console.WriteLine(value.ToString()[2]);
    }
    else
    {
        Console.WriteLine($"В числе {value} нет 3ей цифры =(");
    }
     
}
threeValue();