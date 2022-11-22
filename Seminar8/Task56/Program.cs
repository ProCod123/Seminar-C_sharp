int m = 3;
int n = 5;
int[,] array = new int[m, n];

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
    Console.WriteLine("Был сформирован массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", array[i, j]));
        }
        Console.WriteLine();
    }  
}

void GetMaxSumRow(int[,] array)
{
    //Находим сумму элементов в каждой строке и записываем в массив arraySum
    int[] arraySum = new int [m];
    for (int i = 0; i < m; i++)
    {   
        int sum = 0;
	    for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        arraySum[i] = sum;
        Console.WriteLine($"Сумма элементов в строке № {i} равна {sum}");
    }  
    //Находим наименьший элемент в arraySum и выводим его индекс
    int minRow = arraySum[0];
    int minIndexRow = 0;
    for (int g = 0; g < m; g++)
    {
        if (arraySum[g] < minRow)
        {
            minRow = arraySum[g];
            minIndexRow = g;
        } 
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов {minIndexRow}");
}

FillArray(array);
PrintArray(array);
GetMaxSumRow(array);
