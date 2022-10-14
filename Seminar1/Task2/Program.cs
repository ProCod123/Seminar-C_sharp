Console.WriteLine("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y) Console.WriteLine($"Первое число {x} больше второго {y}");
if (x < y) Console.WriteLine($"Второе число {y} больше первого {x}");
if (x == y) Console.WriteLine("Числа равны");