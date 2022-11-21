void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,99);
        }  
    }
}    

void SearchElement(int[,] array, int m, int n)
{
    if ((m >= 0 && m <=4) && (n >= 0 && n <=4))
    {
        int element = array[m,n];
        Console.WriteLine($"Значение элемента с заданными координатами равно {element}");
    }
    else Console.WriteLine("В массиве отсутствует элемент с такой позицией!!!!!");

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

int[,] array = new int[5, 5];


Console.WriteLine("Введите номер строки элемента ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер колонки элемента ");
int n = Convert.ToInt32(Console.ReadLine());

FillArray(array);
SearchElement(array, m, n);
PrintArray(array);
