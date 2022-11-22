int[,] FillArraySpiral(int n) {
    int[,] result = new int[n, n];

    int pos = 0;
    int count = n;
    int value = -n;
    int sum = -1;

    while (count > 0) {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } 

    return result;
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
int[,] result = FillArraySpiral(4);

PrintArray(result);
