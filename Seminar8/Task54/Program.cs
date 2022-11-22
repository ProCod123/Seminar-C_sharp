int m = 5;
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

void SortString(int[,] array)
{
    for (int i = 0; i < m; i++)
    {   
	    for (int g = 0; g < n - 1; g++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                int temp = 0;
                if (array[i, j + 1] > array[i, j])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
            
        }
    }  
}

FillArray(array);
PrintArray(array);
SortString(array);
Console.WriteLine("После построчной сортировки");
PrintArray(array);
