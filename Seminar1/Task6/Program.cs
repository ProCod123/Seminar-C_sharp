Console.WriteLine("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0) Console.WriteLine($"Число {x} является четным!");
else Console.WriteLine($"Число {x} является НЕчетным!");