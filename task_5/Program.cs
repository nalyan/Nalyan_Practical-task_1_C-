// Показать числа от -N до N
Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = -n;
while (count <= n)
{
    Console.Write(count+ " ");
    count++;
}
