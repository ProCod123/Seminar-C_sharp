
Console.WriteLine("Введите значение x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2){
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}
double distance = GetDistance(x1, y1, z1, x2, y2, z2);

Console.Write($"Рассстояние между точками с указанными координатами равняется {distance}");