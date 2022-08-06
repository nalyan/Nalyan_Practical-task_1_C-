// Показать вторую цифру трёхзначного числа
Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number / 100 < 1 || number / 1000 >= 1) {Console.Write("Это не трёхзначное число");}
else
{
int remains100 = number % 100;
int result = remains100 / 10;

Console.Write("Вторая цифра числа " + number + ": "+  Math.Abs(result));
}