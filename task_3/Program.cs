// Найти максимальное из трех чисел
Console.Clear();

int number1 = new Random().Next(0,500);
int number2 = new Random().Next(0,500);
int number3 = new Random().Next(0,500);

int max = number1;
if (number2 > number1)
{
    if (number2 > number3)
    {
        max = number2;
    }
    else {max = number3;}
}    

else if (number3 > number1) {max = number3;}

Console.WriteLine("Максимальное из трёх числел: " +number1+ ", " +number2+ ", " +number3+ " - будет " +max);