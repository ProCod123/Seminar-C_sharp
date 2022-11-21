int n = 5;
int m = 5;
int[,] array = new int[n, m];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }  
    }
}   
	
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", array[i, j]));
        }
        Console.WriteLine();
    }  
}

void GetSumColumn(int[,] array)
{
    for (int i = 0; i < m; i++)
    {   
        int sum = 0;
	    for (int j = 0; j < n; j++)
        {
            sum += array[j,i];
        }
	    Console.WriteLine($"Сумма чисел в столбце № {i} равна {sum}");
    }  
}

FillArray(array);
PrintArray(array);
GetSumColumn(array);