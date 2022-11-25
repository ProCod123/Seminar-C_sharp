
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int NatureNumber(int n){
    if (n == 1){
        return 1;
    }
    Console.Write(n + ", ");
    return NatureNumber(n - 1);
}

Console.Write($"N = {n} ->  ");
Console.WriteLine(NatureNumber(n));

