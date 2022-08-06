// Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.Clear();

Console.Write("Введите число, проверяемое на кратность: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
int remains = number1 % number2;

if (number1 % number2 ==0) {Console.Write("Число " +number1+ " кратно числу " +number2);}
else {Console.Write("Остаток от деления числа " +number1+ " на число " +number2+ " равен " +remains);}