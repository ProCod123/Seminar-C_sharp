Console.WriteLine("Введите количество строк в первой матрице");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первой матрице");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во второй матрице");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов во второй матрице");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[m1, n1];
int[,] matrixB = new int[m2, n2];
int[,] matrixC = new int[m1, m1]; 

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,10);
        }  
    }
}  

void PrintMatrix(int[,] matrix)
{   
    Console.WriteLine("Была сформирована матрица: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", matrix[i, j]));
        }
        Console.WriteLine();
    }  
}

void MatrixMultiply(int[,] matrix1, int[,] matrix2)
{ 
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int g = 0; g < matrix1.GetLength(0); g++)
                matrixC[i, j] += matrix1[i, g] * matrix2[g, j];  
        }  
    }
} 



if (n1 == m2 && m1 == n2)
{
    FillMatrix(matrixA);
    PrintMatrix(matrixA);
    FillMatrix(matrixB);
    PrintMatrix(matrixB);
    MatrixMultiply(matrixA, matrixB);
    Console.WriteLine("В результате умножения матриц");
    PrintMatrix(matrixC);
}
else Console.WriteLine("Программа остановлена!!!Количество столбцов первой матрицы не равно количеству строк второй матрицы");


