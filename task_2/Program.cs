// По заданному номеру дня недели вывести его название
Console.Clear();

Console.Write("Введите номер дня недели (1-7): ");
int day_number = int.Parse(Console.ReadLine());

if (day_number == 1) {Console.WriteLine(day_number + " день недели - это понедельник");}
else if (day_number == 2) {Console.WriteLine(day_number + " день недели - это вторник");}
else if (day_number == 3) {Console.WriteLine(day_number + " день недели - это среда");}
else if (day_number == 4) {Console.WriteLine(day_number + " день недели - это четверг");}
else if (day_number == 5) {Console.WriteLine(day_number + " день недели - это пятница");}
else if (day_number == 6) {Console.WriteLine(day_number + " день недели - это суббота");}
else if (day_number == 7) {Console.WriteLine(day_number + " день недели - это воскресенье");}
else {Console.WriteLine("нет дня недели с таким номером");}