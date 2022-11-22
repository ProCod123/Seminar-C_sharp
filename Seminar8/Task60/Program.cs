int[,,] array = new int[3, 3, 3];



void FillArray(int[,,] array)
{
    int[] numbers = new int[array.Length];  //Массив для хранения уже сгенерированных чисел
    int h = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                //Для проверки на дубль запустим цикл который будет генерировать новые числа
                // и проверять нет ли дублей. В случае дубля - перезапускаться
                int x = 0;
                int random = 0;
                while (x == 0)
                {
                    random = new Random().Next(1,30);
                    for (int n = 0; n < array.Length; n++)
                    {
                        if (numbers[n] == random)
                        {
                            x = 0;
                            break;
                        }
                        else x = 1;
                    } 
                }
                array[i, j, k] = random;
                numbers[h] = array[i, j, k];
                h++;
            }
        }  
    }
}  

void PrintArray(int[,,] array)
{   
    Console.WriteLine("Был сформирован массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
            }
        }

    }  
}
FillArray(array);
PrintArray(array);