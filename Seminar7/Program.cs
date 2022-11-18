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
// Вывод двумерного массива по форме
// [[8,33 1,68 7,53 ],
//  [9,18 0,02 6,67 ],
//  [4,68 8,44 1,56 ]]
void PrintArray(Double[,] array)
{
    Console.Write("[");
    for (int i = 0; i < m; i++)
    {
        if (i == 0) Console.Write("[");
        else Console.Write(" [");

        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,3} ", array[i,j]);     
        }  
        if (i < m - 1) Console.WriteLine("],");
        else Console.Write("]]");
    }
}

FillArray(m,n);
PrintArray(array);
