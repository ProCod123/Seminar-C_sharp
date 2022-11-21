Console.WriteLine("Определите размеры массива");
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] array = new double[m, n];

void FillArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*10, 2);
        }  
    }
}    

void PrintArray(Double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", array[i, j]));
        }
        Console.WriteLine();
    }  
}

FillArray(m,n);
Console.WriteLine("Полученный массив");
PrintArray(array);
