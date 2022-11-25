int Akerman(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m != 0 && n == 0) return Akerman(m - 1, 1);
                if (m > 0 && n > 0) return Akerman(m - 1, Akerman(m, n - 1));
                return Akerman(m,n);
            }


Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine(Akerman(m,n));

