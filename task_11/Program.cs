// Найти третью цифру числа или сообщить, что её нет
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 100;
int multi = 1;
if (Math.Abs(number) / count < 1) { Console.Write("В этом числе нет третьей цифры"); }
else
{
    while (multi == 1)
    {
        if (Math.Abs(number) / count < 1) { multi = count / 100; }
        else { count = count * 10; }
    }
    int result = number % multi;
    if (multi == 10) { Console.WriteLine("Третья цифра в числе " + number + ": " + Math.Abs(result)); }
    else
    {
        while (multi != 10)
        {
            result = result / 10;
            multi = multi / 10;
        }
    Console.WriteLine("Третья цифра в числе " + number + ": " + Math.Abs(result));
    }
}
