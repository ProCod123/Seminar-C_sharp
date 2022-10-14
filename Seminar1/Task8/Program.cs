Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int f = 1;

while (f < x)
{
    if (f % 2 == 0) Console.WriteLine(f);
    f = f + 1;
}
