Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени");
int degree = Convert.ToInt32(Console.ReadLine());
int multiplier = number;


for (int i = 1; i < degree; i++){
    number = number * multiplier;
}
Console.WriteLine(number);