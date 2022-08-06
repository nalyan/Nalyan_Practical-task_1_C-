// Показать последнюю цифру трёхзначного числа
Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = number % 10;
Console.Write("Последняя цифра числа " +number+ ": " + Math.Abs(result));
