// Удалить вторую цифру трёхзначного числа
Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int figure2 = (number % 100) / 10;
int figure3 = number % 10;
int result = number / 10 - figure2 + figure3;
Console.Write("Результат удаления второй цифры из числа " +number+ " равен: " +result);