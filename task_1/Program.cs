// По двум заданным числам проверять является ли первое квадратом второго
Console.Clear();

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число (" + number1 + ") является квадратом второго (" + number2 + ")");
}
else
{
    Console.WriteLine("Первое число (" + number1 + ") не является квадратом второго (" + number2 + ")");
}