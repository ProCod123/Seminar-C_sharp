Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

void GetKub(int n){
    for(int x = 1; x <= n; x ++){
        double kub = Math.Pow(x, 3);
        Console.WriteLine($"Куб {x} равен {kub} ");
    }
}

GetKub(n);
