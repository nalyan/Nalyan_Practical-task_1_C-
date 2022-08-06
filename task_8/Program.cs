// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Clear();

int number = new Random().Next(10,100);
int count1 = (number % 100) / 10;
int count2 = number % 10;

if (count1 > count2) {Console.Write("Максимальная цифра числа " +number+ ": " +count1);}
else {Console.Write("Максимальная цифра числа " +number+ ": " +count2);}