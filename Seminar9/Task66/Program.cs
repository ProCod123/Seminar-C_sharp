Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int m, int n){
    if (n == m){
        return n;
    }
    
    return m + SumNumber(m + 1, n);
}

Console.WriteLine($"Сумма чисел в диапазоне от {m} до {n} равна {SumNumber(m, n)}");